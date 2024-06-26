﻿using ResizeImages.Core;
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
    public partial class MainForm : Form
    {
        private CancellationTokenSource _tokenSource;
        private GenerateImages _generateImages;
        private ResizeScale _resizeScale;
        private UserOptions _userOptions;

        private int _countSubFolders;

        private List<string> _outputFiles;

        private struct ResizePaths
        {
            public string InputFile { get; set; }
            public string PathOutput { get; set; }
            public string PathBackup { get; set; }
        }

        public MainForm()
        {
            InitializeComponent();
            _userOptions = new();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            rdbPorcent.Checked = true;
            chkOutputFolder.Checked = false;
            txtOutputFolder.ReadOnly = true;
            btnSelectOutput.Enabled = false;
            picPreview.Visible = false;
            lstFiles.HeaderStyle = ColumnHeaderStyle.None;

            VerifyOptions();
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
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
            if (!File.Exists(path))
            {
                picPreview.Visible = false;
                return;
            }

            try
            {
                const int paisagem = 200;
                const int retrato = 400;

                picPreview.ImageLocation = path;
                using (var imgOrigem = Image.FromFile(path))
                {
                    int previewWidth = imgOrigem.Width < imgOrigem.Height ? paisagem : retrato;
                    picPreview.Size = new Size(previewWidth, 285);
                    picPreview.Left = this.Width - (picPreview.Width + 33);
                }

                picPreview.Visible = true;
            }
            catch (Exception)
            {
                picPreview.Visible = false;
            }
        }

        private void btnSelectInput_Click(object sender, EventArgs e)
        {
            using var dlg = openFileDialog1;
            dlg.Filter = "Imagens |*.jpg;*.jpeg;*.png";
            dlg.FileName = "";
            var result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtInputPath.Text = dlg.FileName;
            }
        }

        private void btnSelectOutput_Click(object sender, EventArgs e)
        {
            using var dlg = folderBrowserDialog1;
            var result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtOutputFolder.Text = folderBrowserDialog1.SelectedPath;
                this.VerifyOptions();
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
            _outputFiles = [];

            lstFiles.Items.Clear();
            lblCountInputs.Text = "0";
            lblCountOutputs.Text = "0";

            if (File.Exists(txtInputPath.Text))
            {
                lblCountInputs.Text = "1";
                // Apenas 1 arquivo selecionado
                var rp = this.GetResizePaths(txtInputPath.Text);

                var outFile = _generateImages.Save(rp.InputFile, _resizeScale, rp.PathOutput, rp.PathBackup);
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
                                                .Count(n => !n.Contains("__output") && !n.Contains("__backup"));

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
                        CarregarImagens(txtInputPath.Text, _userOptions.SeekImageExtensions, progress, token);
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
                ShowPicPreview(Path.Combine(item.Group.Header, item.Text));
        }

        private void txtInputPath_Enter(object sender, EventArgs e)
        {
            txtInputPath.SelectAll();
        }

        private void txtOutputFolder_Enter(object sender, EventArgs e)
        {
            if (chkOutputFolder.Checked)
            {
                txtOutputFolder.Text = _userOptions.OutputDirectory;
            }
            txtOutputFolder.SelectAll();
        }
        private void txtOutputFolder_Leave(object sender, EventArgs e)
        {
            string value = txtOutputFolder.Text;

            // Alterando caminho de destino padrão
            if (chkOutputFolder.Checked)
            {
                if (_userOptions.InputFileExists && value.Length > 0)
                {
                    // se selecionado apenas 1 arquivo de input
                    string path = Path.GetDirectoryName(value);

                    path = path == string.Empty ? "%DIR_ORIGEM%" : path;
                    txtOutputFolder.Text = Path.Combine(path, _userOptions.InputFileName + _userOptions.OutputFileExtension);
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

        void CarregarImagens(string pathFiles, string fileExtensions, IProgress<int> progress, CancellationToken token)
        {
            if (string.IsNullOrEmpty(pathFiles))
            {
                throw new ArgumentException($"'{nameof(pathFiles)}' não pode ser nulo nem vazio.", nameof(pathFiles));
            }

            if (string.IsNullOrEmpty(fileExtensions))
            {
                throw new ArgumentException($"'{nameof(fileExtensions)}' não pode ser nulo nem vazio.", nameof(fileExtensions));
            }

            ArgumentNullException.ThrowIfNull(progress);

            string output = string.Empty;

            var files = Directory.GetFiles(pathFiles, "*.*").Where(f => fileExtensions.Contains(Path.GetExtension(f), StringComparison.CurrentCultureIgnoreCase));

            output = ReplaceOutputFolder(pathFiles);

            int xfile = 0;
            foreach (var file in files)
            {
                if (token.IsCancellationRequested)
                    token.ThrowIfCancellationRequested();

                xfile++;

                var rp = this.GetResizePaths(file, output);
                _generateImages.Save(rp.InputFile, _resizeScale, rp.PathOutput, rp.PathBackup);

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

            if (_userOptions.SeekRecursively)
                foreach (var sub in Directory.GetDirectories(pathFiles))
                {
                    if (token.IsCancellationRequested)
                    {
                        token.ThrowIfCancellationRequested();
                    }

                    if (!sub.Contains(@"\__output") && !sub.Contains(@"\__backup"))
                        CarregarImagens(sub, fileExtensions, progress, token);
                }
        }

        void AddFileList(string sourceFile)
        {
            string grupo = Path.GetDirectoryName(sourceFile);
            string file = Path.GetFileName(sourceFile);

            var oLst = lstFiles.Items.Add(file);

            var oGrp = lstFiles.Groups[grupo];
            oGrp ??= lstFiles.Groups.Add(grupo, grupo);

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
                var temp = rdbOutputCbz.Checked || rdbOutputPdf.Checked ? $@"\{Guid.NewGuid().ToString()[..8]}\" : @"\";
                return _userOptions.OutputDirectory.Replace(@"%DIR_ORIGEM%", path) + temp;
            }
        }

        private ResizePaths GetResizePaths(string inputFile, string output = null)
        {
            ResizePaths p = new()
            {
                InputFile = inputFile,
                PathOutput = output ?? ReplaceOutputFolder(Path.GetDirectoryName(inputFile)),
                PathBackup = rdbOutputReplace.Checked && chkSaveBackup.Checked ? Path.Combine(Path.GetDirectoryName(inputFile), @"__backup\") : string.Empty
            };

            return p;
        }

        private void VerifyOptions()
        {
            var (seekExtensions, outputDirectory, outputType) = GetFileDefinitions();

            _userOptions = new UserOptions
            {
                SeekRecursively = chkSeekRecursively.Checked,
                SeekImageExtensions = seekExtensions,
                InputFullPath = txtInputPath.Text,
                OutputDirectory = outputDirectory,
                OutputType = outputType,
                CustomOutputDirectory = chkOutputFolder.Checked
            };

            bool isRunnable = _userOptions.InputFileExists || _userOptions.InputDirExists;

            SetTextBoxColor(txtInputPath, isRunnable ? Color.LightGray : Color.Red);

            isRunnable &= !string.IsNullOrEmpty(_userOptions.OutputDirectory);
            var outputFolderColor = txtOutputFolder.ReadOnly ? Color.DarkGray : Color.LightGray;

            SetTextBoxColor(txtOutputFolder, string.IsNullOrEmpty(_userOptions.OutputDirectory) ? Color.Red : outputFolderColor);
            txtOutputFolder.Text = _userOptions.OutputFullPath;

            _ = int.TryParse(txtWidth.Text, out int parsedWidth);
            SetTextBoxColor(txtWidth, parsedWidth > 0 ? Color.LightGray : Color.Red);

            _ = int.TryParse(txtHeight.Text, out int parsedHeight);
            SetTextBoxColor(txtHeight, parsedHeight > 0 ? Color.LightGray : Color.Red);

            btnRun.Enabled = isRunnable;
        }

        private (string seekExtensions, string outputDirectory, GenerateImages.EOutputType outputType) GetFileDefinitions()
        {
            string imageExtensions = (chkFilterJPG.Checked ? chkFilterJPG.Tag.ToString() : "") +
                                     (chkFilterPNG.Checked ? ";" + chkFilterPNG.Tag.ToString() : "");

            string outputDirectory = File.Exists(txtInputPath.Text) ? Path.GetDirectoryName(txtInputPath.Text) : "%DIR_ORIGEM%";
            outputDirectory = chkOutputFolder.Checked ? txtOutputFolder.Text : outputDirectory;

            GenerateImages.EOutputType outputType = GenerateImages.EOutputType.None;
            switch (true)
            {
                case var _ when rdbOutputCbz.Checked:
                    outputType = GenerateImages.EOutputType.Cbz;
                    break;
                case var _ when rdbOutputPdf.Checked:
                    outputType = GenerateImages.EOutputType.Pdf;
                    break;
                case var _ when rdbOutputCopy.Checked:
                    outputType = GenerateImages.EOutputType.Copy;
                    break;
                case var _ when rdbOutputReplace.Checked && chkSaveBackup.Checked:
                    outputType = GenerateImages.EOutputType.ReplaceWithBackup;
                    break;
                case var _ when rdbOutputReplace.Checked:
                    outputType = GenerateImages.EOutputType.Replace;
                    break;
            }

            return (imageExtensions, outputDirectory, outputType);
        }

        private static void SetTextBoxColor(TextBox textBox, Color color)
        {
            textBox.ForeColor = color;
        }

        private string SavePackage(string outPath)
        {
            if (_userOptions.OutputType.Equals(GenerateImages.EOutputType.Cbz))
            {
                GenPackageFile cbz = new();
                return cbz.Save(outPath, GenPackageFile.ETypeFile.CbzFile);
            }
            else if (_userOptions.OutputType.Equals(GenerateImages.EOutputType.Pdf))
            {
                GenPackageFile pdf = new();
                return pdf.Save(outPath, GenPackageFile.ETypeFile.PdfFile);
            }

            return null;
        }
    }
}
