
namespace ResizeImages
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnOpenTarget = new System.Windows.Forms.Button();
            this.btnOpenSource = new System.Windows.Forms.Button();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.chkRecursiveFind = new System.Windows.Forms.CheckBox();
            this.chkFilterJPG = new System.Windows.Forms.CheckBox();
            this.chkFilterPNG = new System.Windows.Forms.CheckBox();
            this.txtTargetFolder = new System.Windows.Forms.TextBox();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.chkTargetFolder = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.chkKeepBackup = new System.Windows.Forms.CheckBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.chkReplaceOriginals = new System.Windows.Forms.CheckBox();
            this.chkIgnoreOrientation = new System.Windows.Forms.CheckBox();
            this.chkAspectRatio = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.rdbPorcent = new System.Windows.Forms.RadioButton();
            this.rdbHQ = new System.Windows.Forms.RadioButton();
            this.rdb = new System.Windows.Forms.RadioButton();
            this.rdbMedium = new System.Windows.Forms.RadioButton();
            this.rdbSmall = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lstFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblFolderCount = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlTop.Controls.Add(this.btnOpenTarget);
            this.pnlTop.Controls.Add(this.btnOpenSource);
            this.pnlTop.Controls.Add(this.pnlFilter);
            this.pnlTop.Controls.Add(this.txtTargetFolder);
            this.pnlTop.Controls.Add(this.txtSourcePath);
            this.pnlTop.Controls.Add(this.chkTargetFolder);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(832, 124);
            this.pnlTop.TabIndex = 0;
            // 
            // btnOpenTarget
            // 
            this.btnOpenTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenTarget.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnOpenTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenTarget.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpenTarget.Location = new System.Drawing.Point(790, 87);
            this.btnOpenTarget.Name = "btnOpenTarget";
            this.btnOpenTarget.Size = new System.Drawing.Size(30, 24);
            this.btnOpenTarget.TabIndex = 9;
            this.btnOpenTarget.Text = "...";
            this.btnOpenTarget.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpenTarget.UseVisualStyleBackColor = true;
            this.btnOpenTarget.Click += new System.EventHandler(this.btnOpenTarget_Click);
            // 
            // btnOpenSource
            // 
            this.btnOpenSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenSource.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnOpenSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSource.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpenSource.Location = new System.Drawing.Point(790, 32);
            this.btnOpenSource.Name = "btnOpenSource";
            this.btnOpenSource.Size = new System.Drawing.Size(30, 24);
            this.btnOpenSource.TabIndex = 8;
            this.btnOpenSource.Text = "...";
            this.btnOpenSource.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpenSource.UseVisualStyleBackColor = true;
            this.btnOpenSource.Click += new System.EventHandler(this.btnOpenSource_Click);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilter.Controls.Add(this.chkRecursiveFind);
            this.pnlFilter.Controls.Add(this.chkFilterJPG);
            this.pnlFilter.Controls.Add(this.chkFilterPNG);
            this.pnlFilter.Location = new System.Drawing.Point(404, 2);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(380, 27);
            this.pnlFilter.TabIndex = 7;
            this.pnlFilter.Visible = false;
            // 
            // chkRecursiveFind
            // 
            this.chkRecursiveFind.AutoSize = true;
            this.chkRecursiveFind.Checked = true;
            this.chkRecursiveFind.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRecursiveFind.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkRecursiveFind.Location = new System.Drawing.Point(0, 3);
            this.chkRecursiveFind.Name = "chkRecursiveFind";
            this.chkRecursiveFind.Size = new System.Drawing.Size(134, 23);
            this.chkRecursiveFind.TabIndex = 7;
            this.chkRecursiveFind.Tag = "";
            this.chkRecursiveFind.Text = "Busca recursiva";
            this.chkRecursiveFind.UseVisualStyleBackColor = true;
            this.chkRecursiveFind.CheckedChanged += new System.EventHandler(this.chkRecursiveFind_CheckedChanged);
            // 
            // chkFilterJPG
            // 
            this.chkFilterJPG.AutoSize = true;
            this.chkFilterJPG.Checked = true;
            this.chkFilterJPG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFilterJPG.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkFilterJPG.Location = new System.Drawing.Point(245, 3);
            this.chkFilterJPG.Name = "chkFilterJPG";
            this.chkFilterJPG.Size = new System.Drawing.Size(63, 23);
            this.chkFilterJPG.TabIndex = 5;
            this.chkFilterJPG.Tag = "*.jpg;*.jpeg";
            this.chkFilterJPG.Text = ".jpeg";
            this.chkFilterJPG.UseVisualStyleBackColor = true;
            // 
            // chkFilterPNG
            // 
            this.chkFilterPNG.AutoSize = true;
            this.chkFilterPNG.Checked = true;
            this.chkFilterPNG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFilterPNG.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkFilterPNG.Location = new System.Drawing.Point(326, 3);
            this.chkFilterPNG.Name = "chkFilterPNG";
            this.chkFilterPNG.Size = new System.Drawing.Size(60, 23);
            this.chkFilterPNG.TabIndex = 6;
            this.chkFilterPNG.Tag = "*.png";
            this.chkFilterPNG.Text = ".png";
            this.chkFilterPNG.UseVisualStyleBackColor = true;
            // 
            // txtTargetFolder
            // 
            this.txtTargetFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtTargetFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTargetFolder.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTargetFolder.ForeColor = System.Drawing.Color.LightGray;
            this.txtTargetFolder.Location = new System.Drawing.Point(17, 87);
            this.txtTargetFolder.Name = "txtTargetFolder";
            this.txtTargetFolder.PlaceholderText = "Destino da Imagem\'s";
            this.txtTargetFolder.Size = new System.Drawing.Size(767, 24);
            this.txtTargetFolder.TabIndex = 4;
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourcePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtSourcePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSourcePath.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSourcePath.ForeColor = System.Drawing.Color.LightGray;
            this.txtSourcePath.Location = new System.Drawing.Point(17, 32);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.PlaceholderText = "Origem da Imagem\'s";
            this.txtSourcePath.Size = new System.Drawing.Size(767, 24);
            this.txtSourcePath.TabIndex = 3;
            this.txtSourcePath.TextChanged += new System.EventHandler(this.txtSourcePath_TextChanged);
            // 
            // chkTargetFolder
            // 
            this.chkTargetFolder.AutoSize = true;
            this.chkTargetFolder.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkTargetFolder.Location = new System.Drawing.Point(17, 64);
            this.chkTargetFolder.Name = "chkTargetFolder";
            this.chkTargetFolder.Size = new System.Drawing.Size(224, 24);
            this.chkTargetFolder.TabIndex = 2;
            this.chkTargetFolder.Text = "Diretório Destino / Imagem";
            this.chkTargetFolder.UseVisualStyleBackColor = true;
            this.chkTargetFolder.CheckedChanged += new System.EventHandler(this.chkTargetFolder_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diretório Origem / Imagem";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlLeft.Controls.Add(this.chkKeepBackup);
            this.pnlLeft.Controls.Add(this.btnRun);
            this.pnlLeft.Controls.Add(this.panel1);
            this.pnlLeft.Controls.Add(this.pnlLine);
            this.pnlLeft.Controls.Add(this.chkReplaceOriginals);
            this.pnlLeft.Controls.Add(this.chkIgnoreOrientation);
            this.pnlLeft.Controls.Add(this.chkAspectRatio);
            this.pnlLeft.Controls.Add(this.label3);
            this.pnlLeft.Controls.Add(this.txtHeight);
            this.pnlLeft.Controls.Add(this.txtWidth);
            this.pnlLeft.Controls.Add(this.rdbPorcent);
            this.pnlLeft.Controls.Add(this.rdbHQ);
            this.pnlLeft.Controls.Add(this.rdb);
            this.pnlLeft.Controls.Add(this.rdbMedium);
            this.pnlLeft.Controls.Add(this.rdbSmall);
            this.pnlLeft.Controls.Add(this.label2);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 124);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(280, 417);
            this.pnlLeft.TabIndex = 1;
            // 
            // chkKeepBackup
            // 
            this.chkKeepBackup.AutoSize = true;
            this.chkKeepBackup.Checked = true;
            this.chkKeepBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeepBackup.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkKeepBackup.Location = new System.Drawing.Point(17, 334);
            this.chkKeepBackup.Name = "chkKeepBackup";
            this.chkKeepBackup.Size = new System.Drawing.Size(252, 23);
            this.chkKeepBackup.TabIndex = 14;
            this.chkKeepBackup.Text = "Manter backup imagem original";
            this.chkKeepBackup.UseVisualStyleBackColor = true;
            this.chkKeepBackup.Visible = false;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnRun.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Location = new System.Drawing.Point(0, 363);
            this.btnRun.Margin = new System.Windows.Forms.Padding(5);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(280, 54);
            this.btnRun.TabIndex = 13;
            this.btnRun.Text = "Começar";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Location = new System.Drawing.Point(17, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 1);
            this.panel1.TabIndex = 5;
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlLine.Location = new System.Drawing.Point(17, 233);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(246, 1);
            this.pnlLine.TabIndex = 4;
            // 
            // chkReplaceOriginals
            // 
            this.chkReplaceOriginals.AutoSize = true;
            this.chkReplaceOriginals.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkReplaceOriginals.Location = new System.Drawing.Point(17, 305);
            this.chkReplaceOriginals.Name = "chkReplaceOriginals";
            this.chkReplaceOriginals.Size = new System.Drawing.Size(203, 23);
            this.chkReplaceOriginals.TabIndex = 12;
            this.chkReplaceOriginals.Text = "Substituir imagem original";
            this.chkReplaceOriginals.UseVisualStyleBackColor = true;
            this.chkReplaceOriginals.CheckedChanged += new System.EventHandler(this.chkReplaceOriginals_CheckedChanged);
            // 
            // chkIgnoreOrientation
            // 
            this.chkIgnoreOrientation.AutoSize = true;
            this.chkIgnoreOrientation.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkIgnoreOrientation.Location = new System.Drawing.Point(17, 276);
            this.chkIgnoreOrientation.Name = "chkIgnoreOrientation";
            this.chkIgnoreOrientation.Size = new System.Drawing.Size(256, 23);
            this.chkIgnoreOrientation.TabIndex = 11;
            this.chkIgnoreOrientation.Text = "Ignorar a orientação da imagem";
            this.chkIgnoreOrientation.UseVisualStyleBackColor = true;
            // 
            // chkAspectRatio
            // 
            this.chkAspectRatio.AutoSize = true;
            this.chkAspectRatio.Checked = true;
            this.chkAspectRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAspectRatio.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkAspectRatio.Location = new System.Drawing.Point(17, 247);
            this.chkAspectRatio.Name = "chkAspectRatio";
            this.chkAspectRatio.Size = new System.Drawing.Size(229, 23);
            this.chkAspectRatio.TabIndex = 10;
            this.chkAspectRatio.Text = "Manter a taxa de proporção";
            this.chkAspectRatio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(129, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "x";
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeight.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHeight.ForeColor = System.Drawing.Color.LightGray;
            this.txtHeight.Location = new System.Drawing.Point(156, 194);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(77, 24);
            this.txtHeight.TabIndex = 8;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // txtWidth
            // 
            this.txtWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWidth.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWidth.ForeColor = System.Drawing.Color.LightGray;
            this.txtWidth.Location = new System.Drawing.Point(41, 194);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(77, 24);
            this.txtWidth.TabIndex = 7;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWidth_KeyPress);
            // 
            // rdbPorcent
            // 
            this.rdbPorcent.AutoSize = true;
            this.rdbPorcent.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbPorcent.Location = new System.Drawing.Point(29, 155);
            this.rdbPorcent.Name = "rdbPorcent";
            this.rdbPorcent.Size = new System.Drawing.Size(121, 23);
            this.rdbPorcent.TabIndex = 6;
            this.rdbPorcent.Text = "Porcentagem";
            this.rdbPorcent.UseVisualStyleBackColor = true;
            this.rdbPorcent.CheckedChanged += new System.EventHandler(this.rdbPorcent_CheckedChanged);
            // 
            // rdbHQ
            // 
            this.rdbHQ.AutoSize = true;
            this.rdbHQ.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbHQ.Location = new System.Drawing.Point(29, 126);
            this.rdbHQ.Name = "rdbHQ";
            this.rdbHQ.Size = new System.Drawing.Size(179, 23);
            this.rdbHQ.TabIndex = 5;
            this.rdbHQ.Text = "HQ ( 720 x 1080 pixels)";
            this.rdbHQ.UseVisualStyleBackColor = true;
            this.rdbHQ.CheckedChanged += new System.EventHandler(this.rdbHQ_CheckedChanged);
            // 
            // rdb
            // 
            this.rdb.AutoSize = true;
            this.rdb.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdb.Location = new System.Drawing.Point(29, 97);
            this.rdb.Name = "rdb";
            this.rdb.Size = new System.Drawing.Size(219, 23);
            this.rdb.TabIndex = 4;
            this.rdb.Text = "Grande ( 1920 x 1080 pixels)";
            this.rdb.UseVisualStyleBackColor = true;
            this.rdb.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
            // 
            // rdbMedium
            // 
            this.rdbMedium.AutoSize = true;
            this.rdbMedium.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbMedium.Location = new System.Drawing.Point(29, 68);
            this.rdbMedium.Name = "rdbMedium";
            this.rdbMedium.Size = new System.Drawing.Size(201, 23);
            this.rdbMedium.TabIndex = 3;
            this.rdbMedium.Text = "Médio ( 1366 x 768 pixels)";
            this.rdbMedium.UseVisualStyleBackColor = true;
            this.rdbMedium.CheckedChanged += new System.EventHandler(this.rdbMedium_CheckedChanged);
            // 
            // rdbSmall
            // 
            this.rdbSmall.AutoSize = true;
            this.rdbSmall.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbSmall.Location = new System.Drawing.Point(29, 39);
            this.rdbSmall.Name = "rdbSmall";
            this.rdbSmall.Size = new System.Drawing.Size(212, 23);
            this.rdbSmall.TabIndex = 2;
            this.rdbSmall.Text = "Pequeno ( 854 x 480 pixels)";
            this.rdbSmall.UseVisualStyleBackColor = true;
            this.rdbSmall.CheckedChanged += new System.EventHandler(this.rdbSmall_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Redimensionar";
            // 
            // progBar
            // 
            this.progBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progBar.Location = new System.Drawing.Point(0, 541);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(832, 5);
            this.progBar.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lstFiles
            // 
            this.lstFiles.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.lstFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFiles.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstFiles.ForeColor = System.Drawing.Color.White;
            this.lstFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstFiles.HideSelection = false;
            this.lstFiles.HotTracking = true;
            this.lstFiles.HoverSelection = true;
            this.lstFiles.Location = new System.Drawing.Point(280, 124);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(552, 417);
            this.lstFiles.TabIndex = 2;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.View = System.Windows.Forms.View.Details;
            this.lstFiles.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstFiles_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Width = 400;
            // 
            // picPreview
            // 
            this.picPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picPreview.Location = new System.Drawing.Point(631, 287);
            this.picPreview.Name = "picPreview";
            this.picPreview.Padding = new System.Windows.Forms.Padding(8);
            this.picPreview.Size = new System.Drawing.Size(185, 235);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 3;
            this.picPreview.TabStop = false;
            // 
            // lblFolderCount
            // 
            this.lblFolderCount.BackColor = System.Drawing.Color.Transparent;
            this.lblFolderCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFolderCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFolderCount.Font = new System.Drawing.Font("Roboto", 140.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFolderCount.ForeColor = System.Drawing.Color.Black;
            this.lblFolderCount.Location = new System.Drawing.Point(280, 316);
            this.lblFolderCount.Name = "lblFolderCount";
            this.lblFolderCount.Size = new System.Drawing.Size(552, 225);
            this.lblFolderCount.TabIndex = 4;
            this.lblFolderCount.Text = "0";
            this.lblFolderCount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblFolderCount.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(832, 546);
            this.Controls.Add(this.lblFolderCount);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.progBar);
            this.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Redimensionar Imagens";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.CheckBox chkFilterJPG;
        private System.Windows.Forms.CheckBox chkFilterPNG;
        private System.Windows.Forms.TextBox txtTargetFolder;
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.CheckBox chkTargetFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.RadioButton rdbPorcent;
        private System.Windows.Forms.RadioButton rdbHQ;
        private System.Windows.Forms.RadioButton rdb;
        private System.Windows.Forms.RadioButton rdbMedium;
        private System.Windows.Forms.RadioButton rdbSmall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView lstFiles;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.CheckBox chkIgnoreOrientation;
        private System.Windows.Forms.CheckBox chkAspectRatio;
        private System.Windows.Forms.CheckBox chkReplaceOriginals;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Button btnOpenTarget;
        private System.Windows.Forms.Button btnOpenSource;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox chkRecursiveFind;
        private System.Windows.Forms.CheckBox chkKeepBackup;
        private System.Windows.Forms.Label lblFolderCount;
    }
}

