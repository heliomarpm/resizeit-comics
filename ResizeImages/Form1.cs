using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResizeImages
{
    public partial class Form1 : Form
    {
        CancellationTokenSource _tokenSource;
        string _targetFolder;
        List<string> _outputs;
        int _countSubFolders;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbPorcent.Checked = true;
            chkTargetFolder.Checked = false;
            picPreview.Visible = false;
            lstFiles.HeaderStyle = ColumnHeaderStyle.None;
            //lstFiles.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            btnRun.Enabled = false;

            SetTargetFolderDefault();
        }

        void SetSizeOption(int width, int height)
        {
            txtWidth.Text = width.ToString();
            txtHeight.Text = height.ToString();
        }

        private static bool HandleOnlyNumber(KeyPressEventArgs e)
        {
            char chr = Convert.ToChar(e.KeyChar);
            return !char.IsDigit(chr);
        }

        private void SetTargetFolderDefault()
        {
            txtTargetFolder.ReadOnly = !chkTargetFolder.Checked;
            btnOpenTarget.Enabled = chkTargetFolder.Checked;

            if (txtTargetFolder.ReadOnly && !string.IsNullOrEmpty(txtSourcePath.Text))
            {
                if (!File.Exists(txtSourcePath.Text))
                    txtTargetFolder.Text = @"??\__output";
                else
                    txtTargetFolder.Text = Path.Combine(txtSourcePath.Tag.ToString(), @"__output");
            }
        }

        private void rdbPorcent_CheckedChanged(object sender, EventArgs e)
        {
            SetSizeOption(90, 90);
        }

        private void rdbHQ_CheckedChanged(object sender, EventArgs e)
        {
            SetSizeOption(720, 1080);
        }

        private void rdb_CheckedChanged(object sender, EventArgs e)
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

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = HandleOnlyNumber(e);
        }

        private void txtSourcePath_TextChanged(object sender, EventArgs e)
        {
            string path = txtSourcePath.Text;
            bool fileExist = File.Exists(path);

            txtSourcePath.Tag = Path.GetDirectoryName(fileExist ? path : path + @"\");
            SetTargetFolderDefault();

            pnlFilter.Visible = !fileExist;
            btnRun.Enabled = fileExist || Directory.Exists(path);

            ShowPicPreview(path);
        }

        private void ShowPicPreview(string path)
        {
            try
            {
                picPreview.Visible = File.Exists(path);

                if (picPreview.Visible)
                {
                    picPreview.ImageLocation = path;

                    var imgOrigem = Image.FromFile(path);
                    if (imgOrigem.Width < imgOrigem.Height)
                    {
                        //retrato
                        picPreview.Size = new Size(185, 235);
                    }
                    else
                    {
                        //paisagem
                        picPreview.Size = new Size(185 * 2, 235);
                    }
                    picPreview.Left = this.Width - (picPreview.Width + 33);
                }
            }
            catch (Exception)
            {
                picPreview.Visible = false;

            }
            
        }

        private void btnOpenSource_Click(object sender, EventArgs e)
        {
            var dlg = openFileDialog1;

            dlg.Filter = "Jpg|*.jpg|Jpeg|*.jpeg|Png|*.png";
            var result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtSourcePath.Text = dlg.FileName;
            }
        }

        private void btnOpenTarget_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtTargetFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }


        private void chkTargetFolder_CheckedChanged(object sender, EventArgs e)
        {
            SetTargetFolderDefault();
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
            if (btnRun.Text == "Cancelar")
            {
                _tokenSource.Cancel();
                return;
            }

            picPreview.ImageLocation = null;

            if (string.IsNullOrWhiteSpace(txtTargetFolder.Text))
                SetTargetFolderDefault();

            _outputs = new List<string>();
            lstFiles.Items.Clear();

            if (File.Exists(txtSourcePath.Text))
            {
                if (chkReplaceOriginals.Checked)
                    txtTargetFolder.Text = string.Empty;

                ResizeImage(txtSourcePath.Text, txtTargetFolder.Text, chkKeepBackup.Visible && chkKeepBackup.Checked);
                AddFileList(_outputs[0]);
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
                    _countSubFolders = Directory.GetDirectories(txtSourcePath.Text, "*", SearchOption.AllDirectories)
                                                .Where(n => !n.Contains("__output") && !n.Contains("__backup")).Count() + 1;
                    lblFolderCount.Text = _countSubFolders.ToString();
                    lblFolderCount.Visible = true;

                    if (chkReplaceOriginals.Checked)
                        txtTargetFolder.Text = string.Empty;

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
                    });

                    await Task.Run(() =>
                    {
                        string ext = chkFilterJPG.Checked ? chkFilterJPG.Tag.ToString() : string.Empty;
                        ext += chkFilterPNG.Checked ? (!ext.Equals(string.Empty) ? ";" : "") + chkFilterPNG.Tag.ToString() : string.Empty;

                        _targetFolder = txtTargetFolder.Text;

                        CarregarImagens(txtSourcePath.Text, ext, progress, token);
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

                    progBar.Value = 0;
                    progBar.Maximum = _outputs.Count;
                    foreach (var item in _outputs)
                    {
                        AddFileList(item);
                        progBar.Value++;
                    }
                    _tokenSource.Dispose();                    
                }

            }

        }

        void CarregarImagens(string pathFiles, string fileExtensions, IProgress<int> progress, CancellationToken token)
        {
            var files = Directory.GetFiles(pathFiles, "*.*").Where(f => fileExtensions.Contains(Path.GetExtension(f).ToLower()));
           
            string target = _targetFolder.Replace(@"??\", pathFiles + @"\");
            bool keepBackup = chkKeepBackup.Visible && chkKeepBackup.Checked;

            //progBar.Maximum = files.Count();

            int xfile = 0;
            foreach (var file in files)
            {
                if (token.IsCancellationRequested)
                {
                    token.ThrowIfCancellationRequested();
                }
                
                ResizeImage(file, target, keepBackup);

                xfile++;

                var percent = (xfile * 100) / files.Count();
                progress.Report(percent);

            }
            //Se não chamou progress.Report
            if (xfile == 0) _countSubFolders--;

            if (chkRecursiveFind.Checked)
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

        void ResizeImage(string sourceFile, string targetFolder = null, bool replaceSourceWithBackup = false)
        {
            string fname = Path.GetFileNameWithoutExtension(sourceFile);
            string fpath = Path.GetDirectoryName(sourceFile);

            if (string.IsNullOrEmpty(targetFolder) || replaceSourceWithBackup)
                targetFolder = fpath;

            //lblMsg.Text = fpath.Substring(fpath.LastIndexOf(@"\")) + @"\" + fname;

            //' create New image and bitmap objects. Load the image file and put into a resized bitmap.
            var imgOrigem = Image.FromFile(sourceFile);
            bool retrato = imgOrigem.Width <= imgOrigem.Height;

            if (string.IsNullOrEmpty(txtWidth.Text)) txtWidth.Text = imgOrigem.Width.ToString();
            if (string.IsNullOrEmpty(txtHeight.Text)) txtHeight.Text = imgOrigem.Height.ToString();

            //Redimensiona o tamanho da imagem
            float width = Convert.ToInt32(txtWidth.Text);
            float height = Convert.ToInt32(txtHeight.Text);

            if (!chkIgnoreOrientation.Checked)
            {
                // Se é pra manter a orientação então inverte se estiver diferente da imagem original
                if (width <= height && !retrato)
                {
                    width = Convert.ToInt32(txtHeight.Text);
                    height = Convert.ToInt32(txtWidth.Text);
                }
            }

            if (rdbPorcent.Checked)
            {
                width = imgOrigem.Width * (width / 100);
                height = imgOrigem.Height * (height / 100);
            }
            else
            {
                if (chkAspectRatio.Checked)
                {
                    float percetual;

                    if (width > 0)
                    {
                        if (width == imgOrigem.Width)
                        {
                            height = imgOrigem.Height; //mantem original
                        }
                        else
                        {
                            percetual = (float)width / imgOrigem.Width;
                            height = (imgOrigem.Height * percetual);
                        }
                    }
                    else if (height > 0)
                    {
                        if (height == imgOrigem.Height)
                        {
                            width = imgOrigem.Width; //mantem original
                        }
                        else
                        {
                            percetual = (float)height / imgOrigem.Height;
                            width = (imgOrigem.Width * percetual);
                        }
                    }

                    if (width == 0) width = imgOrigem.Width;
                    if (height == 0) height = imgOrigem.Height;
                }

            }

            Bitmap imgOutput = new(imgOrigem, (int)width, (int)height);

            string path = targetFolder;

            //if (string.IsNullOrEmpty(path))
            //    path = String.Format(@"{0}\__output", Path.GetDirectoryName(sourceFile));

            string ext = Path.GetExtension(sourceFile).ToLower();

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            path = String.Format(@"{0}\{1}{2}", path, fname, ext);

            var tipoImage = imgOrigem.RawFormat;
            imgOrigem.Dispose();

            if (replaceSourceWithBackup)
            {
                // Se não estiver explicito para substuir original, então cria um backup da original
                fpath = Path.Combine(fpath, @"__backup");
                if (!Directory.Exists(fpath))
                {
                    Directory.CreateDirectory(fpath);
                    _countSubFolders++;
                }

                File.Copy(sourceFile, Path.Combine(fpath, fname), true);
            }
                       

            // Para evitar o erro de GDI+ quando o caminho é muito longo
            using (MemoryStream ms = new MemoryStream())
            {
                var imgCodec = GetEncoderInfo(tipoImage);
                imgOutput.Save(ms, imgCodec, null);
                ms.ToArray();
                File.WriteAllBytes(path, ms.ToArray());
            }
            //imgOutput.Save(shortPath.ToString(), tipoImage);
            imgOutput.Dispose();

            _outputs.Add(path);
            //AddFileList(path);
        }

        private static ImageCodecInfo GetEncoderInfo(ImageFormat imageFormat)
        {
            string mimeType = $"image/{imageFormat.ToString().ToLower()}";
            
            // Get image codecs for all image formats
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            // Find the correct image codec
            for (int i = 0; i < codecs.Length; i++)
                if (codecs[i].MimeType.ToLower() == mimeType)
                    return codecs[i];

            return null;
        }

        private void chkRecursiveFind_CheckedChanged(object sender, EventArgs e)
        {
            SetTargetFolderDefault();
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
        }

        private void lstFiles_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = lstFiles.FocusedItem;
            if (item != null)
                ShowPicPreview(Path.Combine(item.Group.Header, item.Text));
        }

        private void chkReplaceOriginals_CheckedChanged(object sender, EventArgs e)
        {
            chkKeepBackup.Visible = chkReplaceOriginals.Checked;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (lstFiles.Columns.Count > 0)
                lstFiles.Columns[0].Width = lstFiles.Width - 20;
        }

        private void txtSourcePath_Enter(object sender, EventArgs e)
        {
            txtSourcePath.SelectAll();
        }

        private void txtTargetFolder_Enter(object sender, EventArgs e)
        {
            txtTargetFolder.SelectAll();
        }

        private void picPreview_Click(object sender, EventArgs e)
        {
            picPreview.Dock = picPreview.Dock == DockStyle.None ? DockStyle.Fill : DockStyle.None;
            if (picPreview.Dock == DockStyle.None)
            {
                ShowPicPreview(picPreview.ImageLocation);
            }
        }
    }
}
