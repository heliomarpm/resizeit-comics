
namespace ResizeImages
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            pnlLine = new System.Windows.Forms.Panel();
            lblFolderCount = new System.Windows.Forms.Label();
            rdbOutputPdf = new System.Windows.Forms.RadioButton();
            rdbOutputCbz = new System.Windows.Forms.RadioButton();
            label3 = new System.Windows.Forms.Label();
            txtHeight = new System.Windows.Forms.TextBox();
            txtWidth = new System.Windows.Forms.TextBox();
            rdbPorcent = new System.Windows.Forms.RadioButton();
            rdbHQ = new System.Windows.Forms.RadioButton();
            rdbLarge = new System.Windows.Forms.RadioButton();
            rdbMedium = new System.Windows.Forms.RadioButton();
            rdbSmall = new System.Windows.Forms.RadioButton();
            label2 = new System.Windows.Forms.Label();
            picPreview = new System.Windows.Forms.PictureBox();
            panel4 = new System.Windows.Forms.Panel();
            rdbOutputReplace = new System.Windows.Forms.RadioButton();
            rdbOutputCopy = new System.Windows.Forms.RadioButton();
            label5 = new System.Windows.Forms.Label();
            chkSaveBackup = new System.Windows.Forms.CheckBox();
            lstFiles = new System.Windows.Forms.ListView();
            panel2 = new System.Windows.Forms.Panel();
            lblReduceType = new System.Windows.Forms.Label();
            chkPreserveOrientation = new System.Windows.Forms.CheckBox();
            chkAspectRatio = new System.Windows.Forms.CheckBox();
            pnlTop = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            btnSelectOutput = new System.Windows.Forms.Button();
            btnSelectInput = new System.Windows.Forms.Button();
            txtOutputFolder = new System.Windows.Forms.TextBox();
            txtInputPath = new System.Windows.Forms.TextBox();
            chkOutputFolder = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            pnlFilter = new System.Windows.Forms.Panel();
            chkSeekRecursively = new System.Windows.Forms.CheckBox();
            chkFilterJPG = new System.Windows.Forms.CheckBox();
            chkFilterPNG = new System.Windows.Forms.CheckBox();
            pnlLeft = new System.Windows.Forms.Panel();
            btnRun = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            progBar = new System.Windows.Forms.ProgressBar();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            panel3 = new System.Windows.Forms.Panel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            pnlCountInputs = new System.Windows.Forms.Panel();
            lblCountInputs = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label6 = new System.Windows.Forms.Label();
            pnlCountOutputs = new System.Windows.Forms.Panel();
            lblCountOutputs = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            pnlTop.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlLeft.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlCountInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlCountOutputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Name = "columnHeader1";
            columnHeader1.Width = 400;
            // 
            // pnlLine
            // 
            pnlLine.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            pnlLine.Location = new System.Drawing.Point(17, 218);
            pnlLine.Name = "pnlLine";
            pnlLine.Size = new System.Drawing.Size(275, 3);
            pnlLine.TabIndex = 20;
            // 
            // lblFolderCount
            // 
            lblFolderCount.BackColor = System.Drawing.Color.Transparent;
            lblFolderCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            lblFolderCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblFolderCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 140.25F, System.Drawing.FontStyle.Bold);
            lblFolderCount.ForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            lblFolderCount.Location = new System.Drawing.Point(308, 411);
            lblFolderCount.Name = "lblFolderCount";
            lblFolderCount.Size = new System.Drawing.Size(656, 225);
            lblFolderCount.TabIndex = 10;
            lblFolderCount.Text = "0";
            lblFolderCount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            lblFolderCount.Visible = false;
            // 
            // rdbOutputPdf
            // 
            rdbOutputPdf.AutoSize = true;
            rdbOutputPdf.Font = new System.Drawing.Font("Century Gothic", 10F);
            rdbOutputPdf.Location = new System.Drawing.Point(31, 59);
            rdbOutputPdf.Name = "rdbOutputPdf";
            rdbOutputPdf.Size = new System.Drawing.Size(130, 23);
            rdbOutputPdf.TabIndex = 17;
            rdbOutputPdf.Text = "Unificar em Pdf";
            toolTip1.SetToolTip(rdbOutputPdf, "Unifica todas as imagens da pasta de origem em um arquivo .Pdf de mesmo nome.");
            rdbOutputPdf.UseVisualStyleBackColor = true;
            rdbOutputPdf.CheckedChanged += rdbOutputPdf_CheckedChanged;
            // 
            // rdbOutputCbz
            // 
            rdbOutputCbz.AutoSize = true;
            rdbOutputCbz.Checked = true;
            rdbOutputCbz.Font = new System.Drawing.Font("Century Gothic", 10F);
            rdbOutputCbz.Location = new System.Drawing.Point(31, 33);
            rdbOutputCbz.Name = "rdbOutputCbz";
            rdbOutputCbz.Size = new System.Drawing.Size(135, 23);
            rdbOutputCbz.TabIndex = 16;
            rdbOutputCbz.TabStop = true;
            rdbOutputCbz.Text = "Unificar em Cbz";
            toolTip1.SetToolTip(rdbOutputCbz, "Unifica todas as imagens da pasta de origem em um arquivo .Cbz (padrão HQ) de mesmo nome.\r\n");
            rdbOutputCbz.UseVisualStyleBackColor = true;
            rdbOutputCbz.CheckedChanged += rdbOutputCbz_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 11F);
            label3.Location = new System.Drawing.Point(205, 186);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(16, 20);
            label3.TabIndex = 18;
            label3.Text = "x";
            // 
            // txtHeight
            // 
            txtHeight.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtHeight.Font = new System.Drawing.Font("Century Gothic", 10F);
            txtHeight.ForeColor = System.Drawing.Color.LightGray;
            txtHeight.Location = new System.Drawing.Point(224, 184);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new System.Drawing.Size(67, 24);
            txtHeight.TabIndex = 17;
            txtHeight.Text = "999999";
            txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtHeight.TextChanged += txtHeight_TextChanged;
            txtHeight.KeyPress += txtHeight_KeyPress;
            // 
            // txtWidth
            // 
            txtWidth.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            txtWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtWidth.Font = new System.Drawing.Font("Century Gothic", 10F);
            txtWidth.ForeColor = System.Drawing.Color.LightGray;
            txtWidth.Location = new System.Drawing.Point(135, 184);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new System.Drawing.Size(67, 24);
            txtWidth.TabIndex = 16;
            txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtWidth.TextChanged += txtWidth_TextChanged;
            txtWidth.KeyPress += txtWidth_KeyPress;
            // 
            // rdbPorcent
            // 
            rdbPorcent.AutoSize = true;
            rdbPorcent.Font = new System.Drawing.Font("Century Gothic", 10F);
            rdbPorcent.Location = new System.Drawing.Point(31, 151);
            rdbPorcent.Name = "rdbPorcent";
            rdbPorcent.Size = new System.Drawing.Size(121, 23);
            rdbPorcent.TabIndex = 15;
            rdbPorcent.Text = "Porcentagem";
            rdbPorcent.UseVisualStyleBackColor = true;
            rdbPorcent.CheckedChanged += rdbPorcent_CheckedChanged;
            // 
            // rdbHQ
            // 
            rdbHQ.AutoSize = true;
            rdbHQ.Font = new System.Drawing.Font("Century Gothic", 10F);
            rdbHQ.Location = new System.Drawing.Point(31, 122);
            rdbHQ.Name = "rdbHQ";
            rdbHQ.Size = new System.Drawing.Size(179, 23);
            rdbHQ.TabIndex = 14;
            rdbHQ.Text = "HQ ( 720 x 1080 pixels)";
            rdbHQ.UseVisualStyleBackColor = true;
            rdbHQ.CheckedChanged += rdbHQ_CheckedChanged;
            // 
            // rdbLarge
            // 
            rdbLarge.AutoSize = true;
            rdbLarge.Font = new System.Drawing.Font("Century Gothic", 10F);
            rdbLarge.Location = new System.Drawing.Point(31, 93);
            rdbLarge.Name = "rdbLarge";
            rdbLarge.Size = new System.Drawing.Size(219, 23);
            rdbLarge.TabIndex = 13;
            rdbLarge.Text = "Grande ( 1920 x 1080 pixels)";
            rdbLarge.UseVisualStyleBackColor = true;
            rdbLarge.CheckedChanged += rdbLarge_CheckedChanged;
            // 
            // rdbMedium
            // 
            rdbMedium.AutoSize = true;
            rdbMedium.Font = new System.Drawing.Font("Century Gothic", 10F);
            rdbMedium.Location = new System.Drawing.Point(31, 64);
            rdbMedium.Name = "rdbMedium";
            rdbMedium.Size = new System.Drawing.Size(201, 23);
            rdbMedium.TabIndex = 12;
            rdbMedium.Text = "Médio ( 1366 x 768 pixels)";
            rdbMedium.UseVisualStyleBackColor = true;
            rdbMedium.CheckedChanged += rdbMedium_CheckedChanged;
            // 
            // rdbSmall
            // 
            rdbSmall.AutoSize = true;
            rdbSmall.Font = new System.Drawing.Font("Century Gothic", 10F);
            rdbSmall.Location = new System.Drawing.Point(31, 35);
            rdbSmall.Name = "rdbSmall";
            rdbSmall.Size = new System.Drawing.Size(212, 23);
            rdbSmall.TabIndex = 11;
            rdbSmall.Text = "Pequeno ( 854 x 480 pixels)";
            rdbSmall.UseVisualStyleBackColor = true;
            rdbSmall.CheckedChanged += rdbSmall_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            label2.Location = new System.Drawing.Point(16, 8);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(116, 20);
            label2.TabIndex = 10;
            label2.Text = "Redimensionar";
            // 
            // picPreview
            // 
            picPreview.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            picPreview.Location = new System.Drawing.Point(745, 330);
            picPreview.Name = "picPreview";
            picPreview.Padding = new System.Windows.Forms.Padding(8);
            picPreview.Size = new System.Drawing.Size(200, 285);
            picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picPreview.TabIndex = 9;
            picPreview.TabStop = false;
            picPreview.Click += picPreview_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(rdbOutputReplace);
            panel4.Controls.Add(rdbOutputCopy);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(chkSaveBackup);
            panel4.Controls.Add(rdbOutputPdf);
            panel4.Controls.Add(rdbOutputCbz);
            panel4.Dock = System.Windows.Forms.DockStyle.Top;
            panel4.Location = new System.Drawing.Point(0, 282);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(308, 172);
            panel4.TabIndex = 22;
            // 
            // rdbOutputReplace
            // 
            rdbOutputReplace.AutoSize = true;
            rdbOutputReplace.Font = new System.Drawing.Font("Century Gothic", 10F);
            rdbOutputReplace.Location = new System.Drawing.Point(31, 111);
            rdbOutputReplace.Name = "rdbOutputReplace";
            rdbOutputReplace.Size = new System.Drawing.Size(202, 23);
            rdbOutputReplace.TabIndex = 27;
            rdbOutputReplace.Text = "Substituir imagem original";
            toolTip1.SetToolTip(rdbOutputReplace, "Imagem original será substituida.");
            rdbOutputReplace.UseVisualStyleBackColor = true;
            rdbOutputReplace.CheckedChanged += rdbOutputReplace_CheckedChanged;
            // 
            // rdbOutputCopy
            // 
            rdbOutputCopy.AutoSize = true;
            rdbOutputCopy.Font = new System.Drawing.Font("Century Gothic", 10F);
            rdbOutputCopy.Location = new System.Drawing.Point(31, 85);
            rdbOutputCopy.Name = "rdbOutputCopy";
            rdbOutputCopy.Size = new System.Drawing.Size(140, 23);
            rdbOutputCopy.TabIndex = 26;
            rdbOutputCopy.Text = "Criar uma cópia";
            toolTip1.SetToolTip(rdbOutputCopy, "Cópia será numerada, caso o destino selecionado seja o mesmo da imagem original.");
            rdbOutputCopy.UseVisualStyleBackColor = true;
            rdbOutputCopy.CheckedChanged += rdbOutputCopy_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 11F);
            label5.Location = new System.Drawing.Point(16, 8);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(136, 20);
            label5.TabIndex = 25;
            label5.Text = "Opções de Saída";
            // 
            // chkSaveBackup
            // 
            chkSaveBackup.AutoSize = true;
            chkSaveBackup.Enabled = false;
            chkSaveBackup.Font = new System.Drawing.Font("Century Gothic", 10F);
            chkSaveBackup.Location = new System.Drawing.Point(43, 137);
            chkSaveBackup.Name = "chkSaveBackup";
            chkSaveBackup.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            chkSaveBackup.Size = new System.Drawing.Size(201, 23);
            chkSaveBackup.TabIndex = 24;
            chkSaveBackup.Text = "Guardar Backup original";
            toolTip1.SetToolTip(chkSaveBackup, "Opção de armazenar imagem original na pasta \"__backup\" localizado dentro da pasta origem das imagens");
            chkSaveBackup.UseVisualStyleBackColor = true;
            // 
            // lstFiles
            // 
            lstFiles.Activation = System.Windows.Forms.ItemActivation.OneClick;
            lstFiles.BackColor = System.Drawing.Color.FromArgb(23, 23, 23);
            lstFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lstFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1 });
            lstFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            lstFiles.Font = new System.Drawing.Font("Century Gothic", 10F);
            lstFiles.ForeColor = System.Drawing.Color.White;
            lstFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            lstFiles.HotTracking = true;
            lstFiles.HoverSelection = true;
            lstFiles.Location = new System.Drawing.Point(308, 244);
            lstFiles.Name = "lstFiles";
            lstFiles.Size = new System.Drawing.Size(656, 392);
            lstFiles.TabIndex = 8;
            lstFiles.UseCompatibleStateImageBehavior = false;
            lstFiles.View = System.Windows.Forms.View.Details;
            lstFiles.ItemSelectionChanged += lstFiles_ItemSelectionChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblReduceType);
            panel2.Controls.Add(chkPreserveOrientation);
            panel2.Controls.Add(chkAspectRatio);
            panel2.Controls.Add(pnlLine);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtHeight);
            panel2.Controls.Add(txtWidth);
            panel2.Controls.Add(rdbPorcent);
            panel2.Controls.Add(rdbHQ);
            panel2.Controls.Add(rdbLarge);
            panel2.Controls.Add(rdbMedium);
            panel2.Controls.Add(rdbSmall);
            panel2.Controls.Add(label2);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(308, 282);
            panel2.TabIndex = 2;
            // 
            // lblReduceType
            // 
            lblReduceType.AutoSize = true;
            lblReduceType.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            lblReduceType.Location = new System.Drawing.Point(43, 188);
            lblReduceType.Name = "lblReduceType";
            lblReduceType.Size = new System.Drawing.Size(91, 17);
            lblReduceType.TabIndex = 23;
            lblReduceType.Text = "Dimensão % ";
            // 
            // chkPreserveOrientation
            // 
            chkPreserveOrientation.AutoSize = true;
            chkPreserveOrientation.Checked = true;
            chkPreserveOrientation.CheckState = System.Windows.Forms.CheckState.Checked;
            chkPreserveOrientation.Font = new System.Drawing.Font("Century Gothic", 10F);
            chkPreserveOrientation.Location = new System.Drawing.Point(31, 253);
            chkPreserveOrientation.Name = "chkPreserveOrientation";
            chkPreserveOrientation.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            chkPreserveOrientation.Size = new System.Drawing.Size(261, 23);
            chkPreserveOrientation.TabIndex = 22;
            chkPreserveOrientation.Text = "Manter a orientação da imagem";
            chkPreserveOrientation.UseVisualStyleBackColor = true;
            // 
            // chkAspectRatio
            // 
            chkAspectRatio.AutoSize = true;
            chkAspectRatio.Checked = true;
            chkAspectRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            chkAspectRatio.Font = new System.Drawing.Font("Century Gothic", 10F);
            chkAspectRatio.Location = new System.Drawing.Point(31, 224);
            chkAspectRatio.Name = "chkAspectRatio";
            chkAspectRatio.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            chkAspectRatio.Size = new System.Drawing.Size(232, 23);
            chkAspectRatio.TabIndex = 21;
            chkAspectRatio.Text = "Manter a taxa de proporção";
            chkAspectRatio.UseVisualStyleBackColor = true;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = System.Drawing.Color.FromArgb(38, 38, 38);
            pnlTop.Controls.Add(label4);
            pnlTop.Controls.Add(btnSelectOutput);
            pnlTop.Controls.Add(btnSelectInput);
            pnlTop.Controls.Add(txtOutputFolder);
            pnlTop.Controls.Add(txtInputPath);
            pnlTop.Controls.Add(chkOutputFolder);
            pnlTop.Controls.Add(label1);
            pnlTop.Controls.Add(pnlFilter);
            pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTop.Font = new System.Drawing.Font("Century Gothic", 11F);
            pnlTop.Location = new System.Drawing.Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new System.Drawing.Size(964, 124);
            pnlTop.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 11F);
            label4.Location = new System.Drawing.Point(12, 63);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(153, 20);
            label4.TabIndex = 10;
            label4.Text = "Diretório de Destino";
            // 
            // btnSelectOutput
            // 
            btnSelectOutput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSelectOutput.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            btnSelectOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSelectOutput.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            btnSelectOutput.Location = new System.Drawing.Point(918, 87);
            btnSelectOutput.Name = "btnSelectOutput";
            btnSelectOutput.Size = new System.Drawing.Size(30, 24);
            btnSelectOutput.TabIndex = 9;
            btnSelectOutput.Text = "...";
            btnSelectOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnSelectOutput.UseVisualStyleBackColor = true;
            btnSelectOutput.Click += btnSelectOutput_Click;
            // 
            // btnSelectInput
            // 
            btnSelectInput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSelectInput.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            btnSelectInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSelectInput.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            btnSelectInput.Location = new System.Drawing.Point(918, 32);
            btnSelectInput.Name = "btnSelectInput";
            btnSelectInput.Size = new System.Drawing.Size(30, 24);
            btnSelectInput.TabIndex = 8;
            btnSelectInput.Text = "...";
            btnSelectInput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnSelectInput.UseVisualStyleBackColor = true;
            btnSelectInput.Click += btnSelectInput_Click;
            // 
            // txtOutputFolder
            // 
            txtOutputFolder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtOutputFolder.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            txtOutputFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtOutputFolder.Font = new System.Drawing.Font("Century Gothic", 10F);
            txtOutputFolder.ForeColor = System.Drawing.Color.DarkGray;
            txtOutputFolder.Location = new System.Drawing.Point(17, 87);
            txtOutputFolder.Name = "txtOutputFolder";
            txtOutputFolder.PlaceholderText = "Destino da Imagem's";
            txtOutputFolder.Size = new System.Drawing.Size(902, 24);
            txtOutputFolder.TabIndex = 4;
            txtOutputFolder.DoubleClick += txtOutputFolder_Enter;
            txtOutputFolder.Enter += txtOutputFolder_Enter;
            txtOutputFolder.Leave += txtOutputFolder_Leave;
            // 
            // txtInputPath
            // 
            txtInputPath.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtInputPath.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            txtInputPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtInputPath.Font = new System.Drawing.Font("Century Gothic", 10F);
            txtInputPath.ForeColor = System.Drawing.Color.LightGray;
            txtInputPath.Location = new System.Drawing.Point(17, 32);
            txtInputPath.Name = "txtInputPath";
            txtInputPath.PlaceholderText = "Origem da Imagem's";
            txtInputPath.Size = new System.Drawing.Size(902, 24);
            txtInputPath.TabIndex = 3;
            txtInputPath.TextChanged += txtInputPath_TextChanged;
            txtInputPath.DoubleClick += txtInputPath_Enter;
            txtInputPath.Enter += txtInputPath_Enter;
            // 
            // chkOutputFolder
            // 
            chkOutputFolder.AutoSize = true;
            chkOutputFolder.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            chkOutputFolder.Location = new System.Drawing.Point(175, 63);
            chkOutputFolder.Name = "chkOutputFolder";
            chkOutputFolder.Size = new System.Drawing.Size(133, 24);
            chkOutputFolder.TabIndex = 2;
            chkOutputFolder.Text = "alterar destino";
            chkOutputFolder.UseVisualStyleBackColor = true;
            chkOutputFolder.Visible = false;
            chkOutputFolder.CheckedChanged += chkOutputFolder_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 11F);
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(258, 20);
            label1.TabIndex = 0;
            label1.Text = "Diretório de Origem e/ou Imagem";
            // 
            // pnlFilter
            // 
            pnlFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            pnlFilter.Controls.Add(chkSeekRecursively);
            pnlFilter.Controls.Add(chkFilterJPG);
            pnlFilter.Controls.Add(chkFilterPNG);
            pnlFilter.Location = new System.Drawing.Point(641, 2);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new System.Drawing.Size(323, 27);
            pnlFilter.TabIndex = 1;
            pnlFilter.Visible = false;
            // 
            // chkSeekRecursively
            // 
            chkSeekRecursively.AutoSize = true;
            chkSeekRecursively.Checked = true;
            chkSeekRecursively.CheckState = System.Windows.Forms.CheckState.Checked;
            chkSeekRecursively.Font = new System.Drawing.Font("Century Gothic", 10F);
            chkSeekRecursively.Location = new System.Drawing.Point(9, 1);
            chkSeekRecursively.Name = "chkSeekRecursively";
            chkSeekRecursively.Size = new System.Drawing.Size(134, 23);
            chkSeekRecursively.TabIndex = 7;
            chkSeekRecursively.Tag = "";
            chkSeekRecursively.Text = "Busca recursiva";
            chkSeekRecursively.UseVisualStyleBackColor = true;
            // 
            // chkFilterJPG
            // 
            chkFilterJPG.AutoSize = true;
            chkFilterJPG.Checked = true;
            chkFilterJPG.CheckState = System.Windows.Forms.CheckState.Checked;
            chkFilterJPG.Font = new System.Drawing.Font("Century Gothic", 10F);
            chkFilterJPG.Location = new System.Drawing.Point(182, 1);
            chkFilterJPG.Name = "chkFilterJPG";
            chkFilterJPG.Size = new System.Drawing.Size(63, 23);
            chkFilterJPG.TabIndex = 5;
            chkFilterJPG.Tag = "*.jpg;*.jpeg";
            chkFilterJPG.Text = ".jpeg";
            chkFilterJPG.UseVisualStyleBackColor = true;
            // 
            // chkFilterPNG
            // 
            chkFilterPNG.AutoSize = true;
            chkFilterPNG.Checked = true;
            chkFilterPNG.CheckState = System.Windows.Forms.CheckState.Checked;
            chkFilterPNG.Font = new System.Drawing.Font("Century Gothic", 10F);
            chkFilterPNG.Location = new System.Drawing.Point(251, 1);
            chkFilterPNG.Name = "chkFilterPNG";
            chkFilterPNG.Size = new System.Drawing.Size(60, 23);
            chkFilterPNG.TabIndex = 6;
            chkFilterPNG.Tag = "*.png";
            chkFilterPNG.Text = ".png";
            chkFilterPNG.UseVisualStyleBackColor = true;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = System.Drawing.Color.FromArgb(38, 38, 38);
            pnlLeft.Controls.Add(panel4);
            pnlLeft.Controls.Add(btnRun);
            pnlLeft.Controls.Add(panel1);
            pnlLeft.Controls.Add(panel2);
            pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            pnlLeft.Location = new System.Drawing.Point(0, 124);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new System.Drawing.Size(308, 512);
            pnlLeft.TabIndex = 6;
            // 
            // btnRun
            // 
            btnRun.BackColor = System.Drawing.Color.FromArgb(48, 48, 48);
            btnRun.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnRun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(28, 28, 28);
            btnRun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            btnRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(58, 58, 58);
            btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRun.ForeColor = System.Drawing.Color.White;
            btnRun.Location = new System.Drawing.Point(0, 458);
            btnRun.Margin = new System.Windows.Forms.Padding(5);
            btnRun.Name = "btnRun";
            btnRun.Size = new System.Drawing.Size(308, 54);
            btnRun.TabIndex = 13;
            btnRun.Text = "Começar";
            btnRun.UseVisualStyleBackColor = false;
            btnRun.Click += btnRun_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            panel1.Location = new System.Drawing.Point(17, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(275, 3);
            panel1.TabIndex = 5;
            // 
            // progBar
            // 
            progBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            progBar.Location = new System.Drawing.Point(0, 636);
            progBar.Name = "progBar";
            progBar.Size = new System.Drawing.Size(964, 5);
            progBar.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(38, 38, 38);
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(308, 124);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(656, 120);
            panel3.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pnlCountInputs, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlCountOutputs, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(656, 120);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlCountInputs
            // 
            pnlCountInputs.BackColor = System.Drawing.Color.FromArgb(23, 23, 23);
            pnlCountInputs.Controls.Add(lblCountInputs);
            pnlCountInputs.Controls.Add(pictureBox1);
            pnlCountInputs.Controls.Add(label6);
            pnlCountInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlCountInputs.Location = new System.Drawing.Point(0, 0);
            pnlCountInputs.Margin = new System.Windows.Forms.Padding(0, 0, 3, 6);
            pnlCountInputs.Name = "pnlCountInputs";
            pnlCountInputs.Size = new System.Drawing.Size(325, 114);
            pnlCountInputs.TabIndex = 0;
            // 
            // lblCountInputs
            // 
            lblCountInputs.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCountInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            lblCountInputs.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            lblCountInputs.Location = new System.Drawing.Point(4, 41);
            lblCountInputs.Name = "lblCountInputs";
            lblCountInputs.Size = new System.Drawing.Size(242, 70);
            lblCountInputs.TabIndex = 2;
            lblCountInputs.Text = "0";
            lblCountInputs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(252, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(73, 71);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            label6.ForeColor = System.Drawing.Color.Silver;
            label6.Location = new System.Drawing.Point(4, 4);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(176, 42);
            label6.TabIndex = 0;
            label6.Text = "Entradas";
            // 
            // pnlCountOutputs
            // 
            pnlCountOutputs.BackColor = System.Drawing.Color.FromArgb(23, 23, 23);
            pnlCountOutputs.Controls.Add(lblCountOutputs);
            pnlCountOutputs.Controls.Add(label7);
            pnlCountOutputs.Controls.Add(pictureBox2);
            pnlCountOutputs.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlCountOutputs.Location = new System.Drawing.Point(331, 0);
            pnlCountOutputs.Margin = new System.Windows.Forms.Padding(3, 0, 0, 6);
            pnlCountOutputs.Name = "pnlCountOutputs";
            pnlCountOutputs.Size = new System.Drawing.Size(325, 114);
            pnlCountOutputs.TabIndex = 1;
            // 
            // lblCountOutputs
            // 
            lblCountOutputs.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCountOutputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            lblCountOutputs.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            lblCountOutputs.Location = new System.Drawing.Point(5, 41);
            lblCountOutputs.Name = "lblCountOutputs";
            lblCountOutputs.Size = new System.Drawing.Size(242, 70);
            lblCountOutputs.TabIndex = 4;
            lblCountOutputs.Text = "0";
            lblCountOutputs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            label7.ForeColor = System.Drawing.Color.Silver;
            label7.Location = new System.Drawing.Point(3, 4);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(139, 42);
            label7.TabIndex = 3;
            label7.Text = "Saídas";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(252, 43);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(73, 71);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(23, 23, 23);
            ClientSize = new System.Drawing.Size(964, 641);
            Controls.Add(lblFolderCount);
            Controls.Add(picPreview);
            Controls.Add(lstFiles);
            Controls.Add(panel3);
            Controls.Add(pnlLeft);
            Controls.Add(progBar);
            Controls.Add(pnlTop);
            Font = new System.Drawing.Font("Century Gothic", 11F);
            ForeColor = System.Drawing.Color.WhiteSmoke;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "ResizeIt! Redimensionador de Imagens";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += MainForm_Load;
            ResizeEnd += MainForm_ResizeEnd;
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlLeft.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            pnlCountInputs.ResumeLayout(false);
            pnlCountInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlCountOutputs.ResumeLayout(false);
            pnlCountOutputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Label lblFolderCount;
        private System.Windows.Forms.RadioButton rdbOutputPdf;
        private System.Windows.Forms.RadioButton rdbOutputCbz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.RadioButton rdbPorcent;
        private System.Windows.Forms.RadioButton rdbHQ;
        private System.Windows.Forms.RadioButton rdbLarge;
        private System.Windows.Forms.RadioButton rdbMedium;
        private System.Windows.Forms.RadioButton rdbSmall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lstFiles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnSelectOutput;
        private System.Windows.Forms.Button btnSelectInput;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.CheckBox chkSeekRecursively;
        private System.Windows.Forms.CheckBox chkFilterJPG;
        private System.Windows.Forms.CheckBox chkFilterPNG;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.TextBox txtInputPath;
        private System.Windows.Forms.CheckBox chkOutputFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkPreserveOrientation;
        private System.Windows.Forms.CheckBox chkAspectRatio;
        private System.Windows.Forms.RadioButton rdbOutputReplace;
        private System.Windows.Forms.RadioButton rdbOutputCopy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkSaveBackup;
        private System.Windows.Forms.Label lblReduceType;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlCountInputs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlCountOutputs;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCountInputs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCountOutputs;
    }
}

