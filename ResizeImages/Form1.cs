using ResizeImages.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResizeImages
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _tokenSource;
        private GenerateImages _generateImages;
        private ResizeScale _resizeScale;
        private UserOptions _userOp;

        private int _countSubFolders;

        private List<string> _outputFiles;

        private struct ResizePaths
        {
            public string InputFile { get; set; }
            public string pathOutput { get; set; }
            public string pathBackup { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            _userOp = new();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbPorcent.Checked = true;
            chkOutputFolder.Checked = false;
            txtOutputFolder.ReadOnly = true;
            btnSelectOutput.Enabled = false;
            picPreview.Visible = false;
            lstFiles.HeaderStyle = ColumnHeaderStyle.None;

            VerifyOptions();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                if (this.Width < 980) this.Width = 980;
                if (this.Height < 680) this.Height = 680;

                if (lstFiles.Columns.Count > 0)
                    lstFiles.Columns[0].Width = lstFiles.Width - 20;
            }
        }

        void SetSizeOption(int width, int height)
        {
            lblReduceType.Text = rdbPorcent.Checked ? "Dimensão % " : "Dimensão ";
            txtWidth.Text = width.ToString();
            txtHeight.Text = height.ToString();
        }

        private static bool HandleOnlyNumber(KeyPressEventArgs e)
        {
            char chr = Convert.ToChar(e.KeyChar);
            return !char.IsDigit(chr) && !e.KeyChar.Equals((char)Keys.Back);
        }

        private void rdbPorcent_CheckedChanged(object sender, EventArgs e)
        {
            SetSizeOption(90, 90);
        }

        private void rdbHQ_CheckedChanged(object sender, EventArgs e)
        {
            SetSizeOption(720, 1080);
        }

        private void rdbLarge_CheckedChanged(object sender, EventArgs e)
        {
            SetSizeOption(1920, 1080);
        }

        private void rdbMedium_CheckedChanged(object sender, EventArgs e)
        {
            SetSizeOption(1366, 768);
        }

        private void rdbSmall_CheckedChanged(object sender, EventArgs e)
        {
            SetSizeOption(854, 480);
        }

        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = HandleOnlyNumber(e);
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            VerifyOptions();
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = HandleOnlyNumber(e);
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            VerifyOptions();
        }

        private void txtInputPath_TextChanged(object sender, EventArgs e)
        {
            pnlFilter.Visible = !File.Exists(txtInputPath.Text);
            ShowPicPreview(txtInputPath.Text);
            VerifyOptions();
        }

        private void ShowPicPreview(string path)
        {
            try
            {
                picPreview.Visible = File.Exists(path);

                if (picPreview.Visible)
                {
                    picPreview.ImageLocation = path;

                    var imgOrigem = System.Drawing.Image.FromFile(path);
                    if (imgOrigem.Width < imgOrigem.Height)
                    {
                        //retrato
                        picPreview.Size = new Size(200, 285);
                    }
                    else
                    {
                        //paisagem
                        picPreview.Size = new Size(200 * 2, 285);
                    }
                    picPreview.Left = this.Width - (picPreview.Width + 33);
                }
            }
            catch (Exception)
            {
                picPreview.Visible = false;
            }

        }

        private void btnSelectInput_Click(object sender, EventArgs e)
        {
            using (var dlg = openFileDialog1)
            {
                dlg.Filter = "Imagens |*.jpg;*.jpeg;*.png";
                dlg.FileName = "";
                var result = dlg.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtInputPath.Text = dlg.FileName;
                }
            }

        }

        private void btnSelectOutput_Click(object sender, EventArgs e)
        {
            using (var dlg = folderBrowserDialog1)
            {
                var result = dlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtOutputFolder.Text = folderBrowserDialog1.SelectedPath;
                    this.VerifyOptions();
                }
            }
        }

        private void chkOutputFolder_CheckedChanged(object sender, EventArgs e)
        {
            btnSelectOutput.Enabled = chkOutputFolder.Checked;
            txtOutputFolder.ReadOnly = !chkOutputFolder.Checked;

            VerifyOptions();

            //Se vai alterar 
            if (!txtOutputFolder.ReadOnly)
            {
                if (rdbOutputReplace.Checked) rdbOutputCopy.Checked = true;   // volta para seleção de copia
                txtOutputFolder.Focus();
            }
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
            if (btnRun.Text == "Cancelar")
            {
                _tokenSource.Cancel();
                return;
            }

            picPreview.ImageLocation = null;

            _generateImages = new();
            _resizeScale = new(this.GetWidth, this.GetHeight, rdbPorcent.Checked, chkPreserveOrientation.Checked, chkAspectRatio.Checked);
            _outputFiles = new();

            lstFiles.Items.Clear();
            lblCountInputs.Text = "0";
            lblCountOutputs.Text = "0";

            if (File.Exists(txtInputPath.Text))
            {
                lblCountInputs.Text = "1";
                // Apenas 1 arquivo selecionado
                var rp = this.GetResizePaths(txtInputPath.Text);

                var outFile = _generateImages.Save(rp.InputFile, _resizeScale, rp.pathOutput, rp.pathBackup);
                AddFileList(SavePackage(outFile).IsNull(outFile));
            }
            else
            {
                if (!chkFilterJPG.Checked && !chkFilterPNG.Checked)
                {
                    MessageBox.Show("Antes de continuar, é necessário selecionar um tipo de arquivo!", "Tipo de Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                _tokenSource = new CancellationTokenSource();
                var token = _tokenSource.Token;

                try
                {
                    // subfolders 
                    _countSubFolders = Directory.GetDirectories(txtInputPath.Text, "*", SearchOption.AllDirectories)
                                                .Where(n => !n.Contains("__output") && !n.Contains("__backup")).Count();
                    lblFolderCount.Text = _countSubFolders.ToString();
                    lblFolderCount.Visible = _countSubFolders > 0;

                    btnRun.Text = "Cancelar";
                    this.Refresh();

                    progBar.Value = 0;
                    progBar.Maximum = 100; // 100%
                    var progress = new Progress<int>(value =>
                    {
                        progBar.Value = value;

                        if (value == 100)
                        {
                            _countSubFolders--;
                            lblFolderCount.Text = _countSubFolders.ToString();
                            lblFolderCount.Refresh();
                        }

                        lblCountInputs.Text = (Convert.ToInt32(lblCountInputs.Text) + 1).ToString();
                        if ((!rdbOutputCbz.Checked && !rdbOutputPdf.Checked) || value == 100)
                        {
                            lblCountOutputs.Text = (Convert.ToInt32(lblCountOutputs.Text) + 1).ToString();
                        }
                    });

                    await Task.Run(() =>
                    {
                        CarregarImagens(txtInputPath.Text, _userOp.SeekImageExtensions, _userOp.OutputType, progress, token);
                    });

                    btnRun.Text = "Começar";
                }
                catch (OperationCanceledException)
                {
                    btnRun.Text = "Cancelado (Recomeçar)";
                }
                finally
                {
                    lblFolderCount.Visible = false;

                    var outFiles = _outputFiles.Count > 0 ? _outputFiles : _generateImages.Outputs;

                    progBar.Value = 0;
                    progBar.Maximum = outFiles.Count;
                    foreach (var item in outFiles)
                    {
                        AddFileList(item);
                        progBar.Value++;
                    }
                    _tokenSource.Dispose();
                }

            }

        }

        private void lstFiles_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = lstFiles.FocusedItem;
            if (item != null)
                ShowPicPreview(System.IO.Path.Combine(item.Group.Header, item.Text));
        }

        private void txtInputPath_Enter(object sender, EventArgs e)
        {
            txtInputPath.SelectAll();
        }

        private void txtOutputFolder_Enter(object sender, EventArgs e)
        {
            if (chkOutputFolder.Checked)
            {
                txtOutputFolder.Text = _userOp.OutputDirectory;
            }
            txtOutputFolder.SelectAll();
        }
        private void txtOutputFolder_Leave(object sender, EventArgs e)
        {
            string value = txtOutputFolder.Text;

            // Alterando caminho de destino padrão
            if (chkOutputFolder.Checked)
            {
                if (_userOp.InputFileExists && value.Length > 0)
                {
                    // se selecionado apenas 1 arquivo de input
                    string path = Path.GetDirectoryName(value);
                    //string fileName = Path.GetFileName(value);

                    path = path == string.Empty ? "%DIR_ORIGEM%" : path;
                    txtOutputFolder.Text = Path.Combine(path, _userOp.InputFileName + _userOp.OutputFileExtension);
                }
                else if (value.Length > 0 && value[^1].ToString().CompareTo(@"\") == 1)
                {
                    // se origem é um diretorio, adiciona o \ no final
                    txtOutputFolder.Text += @"\";
                }
            }


            VerifyOptions();
        }

        private void picPreview_Click(object sender, EventArgs e)
        {
            picPreview.Dock = picPreview.Dock == DockStyle.None ? DockStyle.Fill : DockStyle.None;
            if (picPreview.Dock == DockStyle.None)
            {
                ShowPicPreview(picPreview.ImageLocation);
            }
        }

        private void rdbOutputCbz_CheckedChanged(object sender, EventArgs e)
        {
            this.VerifyOptions();
        }

        private void rdbOutputPdf_CheckedChanged(object sender, EventArgs e)
        {
            this.VerifyOptions();
        }

        private void rdbOutputCopy_CheckedChanged(object sender, EventArgs e)
        {
            this.VerifyOptions();
        }

        private void rdbOutputReplace_CheckedChanged(object sender, EventArgs e)
        {
            chkSaveBackup.Enabled = rdbOutputReplace.Checked;

            if (rdbOutputReplace.Checked)
            {
                chkOutputFolder.Checked = false;
            }

        }

        void CarregarImagens(string pathFiles, string fileExtensions, GenerateImages.EOutputType outputType, IProgress<int> progress, CancellationToken token)
        {
            string output = string.Empty;

            var files = Directory.GetFiles(pathFiles, "*.*").Where(f => fileExtensions.Contains(System.IO.Path.GetExtension(f).ToLower()));

            output = ReplaceOutputFolder(pathFiles);

            //progBar.Maximum = files.Count();
            int xfile = 0;
            foreach (var file in files)
            {
                if (token.IsCancellationRequested)
                    token.ThrowIfCancellationRequested();

                xfile++;

                var rp = this.GetResizePaths(file, output);
                _generateImages.Save(rp.InputFile, _resizeScale, rp.pathOutput, rp.pathBackup);

                var percent = (xfile * 100) / files.Count();
                progress.Report(percent);

            }
            //Se não chamou progress.Report
            if (xfile == 0)
                _countSubFolders--;
            else
            {
                var pkg = SavePackage(output);
                if (!string.IsNullOrEmpty(pkg))
                {
                    _outputFiles.Add(pkg);
                }
            }


            if (_userOp.SeekRecursively)
                foreach (var sub in Directory.GetDirectories(pathFiles))
                {
                    if (token.IsCancellationRequested)
                    {
                        token.ThrowIfCancellationRequested();
                    }

                    if (!sub.Contains(@"\__output") && !sub.Contains(@"\__backup"))
                        CarregarImagens(sub, fileExtensions, _userOp.OutputType, progress, token);

                }

        }

        void AddFileList(string sourceFile)
        {
            string grupo = Path.GetDirectoryName(sourceFile);
            string file = Path.GetFileName(sourceFile);

            var oLst = lstFiles.Items.Add(file);

            var oGrp = lstFiles.Groups[grupo];
            if (oGrp == null)
            {
                oGrp = lstFiles.Groups.Add(grupo, grupo);
            }

            oLst.Group = oGrp;
            lblCountOutputs.Text = lstFiles.Items.Count.ToString();
        }

        private float GetWidth => string.IsNullOrEmpty(txtWidth.Text) ? 0 : Convert.ToInt32(txtWidth.Text);
        private float GetHeight => string.IsNullOrEmpty(txtHeight.Text) ? 0 : Convert.ToInt32(txtHeight.Text);

        private string ReplaceOutputFolder(string path = "")
        {
            if (rdbOutputReplace.Checked)
                return path + @"\";
            else
            {
                var temp = rdbOutputCbz.Checked || rdbOutputPdf.Checked ? $@"\{Guid.NewGuid().ToString().Substring(0, 8)}\" : @"\";
                return _userOp.OutputDirectory.Replace(@"%DIR_ORIGEM%", path) + temp;
            }

        }

        private ResizePaths GetResizePaths(string inputFile, string output = null)
        {
            ResizePaths p = new();

            p.InputFile = inputFile;
            p.pathOutput = output ?? ReplaceOutputFolder(Path.GetDirectoryName(inputFile));
            p.pathBackup = rdbOutputReplace.Checked && chkSaveBackup.Checked ? Path.Combine(Path.GetDirectoryName(inputFile), @"__backup\") : string.Empty;

            return p;
        }

        private void VerifyOptions()
        {
            // extensoes
            string extFile = chkFilterJPG.Checked ? chkFilterJPG.Tag.ToString() : string.Empty;
            extFile += chkFilterPNG.Checked ? (!extFile.Equals(string.Empty) ? ";" : "") + chkFilterPNG.Tag.ToString() : string.Empty;

            // diretorio output
            string dirOutput = "%DIR_ORIGEM%";

            if (chkOutputFolder.Checked)
                dirOutput = txtOutputFolder.Text;
            else if (File.Exists(txtInputPath.Text))
                dirOutput = Path.GetDirectoryName(txtInputPath.Text + @"\");


            _userOp = new UserOptions
            {
                SeekRecursively = chkSeekRecursively.Checked,
                SeekImageExtensions = extFile,
                InputFullPath = txtInputPath.Text,
                OutputDirectory = dirOutput,
                OutputType = true switch
                {
                    true when rdbOutputCbz.Checked => GenerateImages.EOutputType.Cbz,
                    true when rdbOutputPdf.Checked => GenerateImages.EOutputType.Pdf,
                    true when rdbOutputCopy.Checked => GenerateImages.EOutputType.Copy,
                    true when rdbOutputReplace.Checked && chkSaveBackup.Checked => GenerateImages.EOutputType.ReplaceWithBackup,
                    true when rdbOutputReplace.Checked => GenerateImages.EOutputType.Replace,
                    _ => GenerateImages.EOutputType.None,
                },
                CustomOutputDirectory = chkOutputFolder.Checked
            };

            bool runOK;
            bool bOK;

            bOK = _userOp.InputFileExists || _userOp.InputDirExists;
            runOK = bOK;
            txtInputPath.ForeColor = bOK ? Color.LightGray : Color.Red;

            bOK = !string.IsNullOrEmpty(_userOp.OutputDirectory);
            runOK &= bOK;
            txtOutputFolder.ForeColor = bOK ? txtOutputFolder.ReadOnly ? Color.DarkGray : Color.LightGray : Color.Red;

            //if (!_userOp.CustomOutputDirectory)
            txtOutputFolder.Text = _userOp.OutputFullPath;


            _ = int.TryParse(txtWidth.Text, out int nOK);
            runOK &= bOK;
            txtWidth.ForeColor = nOK > 0 ? Color.LightGray : Color.Red;

            _ = int.TryParse(txtHeight.Text, out nOK);
            runOK &= bOK;
            txtHeight.ForeColor = nOK > 0 ? Color.LightGray : Color.Red;

            btnRun.Enabled = runOK;
        }

        private string SavePackage(string outPath)
        {
            if (_userOp.OutputType.Equals(GenerateImages.EOutputType.Cbz))
            {
                GenPackageFile cbz = new();
                return cbz.Save(outPath, GenPackageFile.ETypeFile.CbzFile);
            }
            else if (_userOp.OutputType.Equals(GenerateImages.EOutputType.Pdf))
            {
                GenPackageFile pdf = new();
                return pdf.Save(outPath, GenPackageFile.ETypeFile.PdfFile);
            }

            return null;
        }


    }

}
