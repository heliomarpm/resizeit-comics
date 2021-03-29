
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.lblFolderCount = new System.Windows.Forms.Label();
            this.rdbOutputPdf = new System.Windows.Forms.RadioButton();
            this.rdbOutputCbz = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.rdbPorcent = new System.Windows.Forms.RadioButton();
            this.rdbHQ = new System.Windows.Forms.RadioButton();
            this.rdbLarge = new System.Windows.Forms.RadioButton();
            this.rdbMedium = new System.Windows.Forms.RadioButton();
            this.rdbSmall = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdbOutputReplace = new System.Windows.Forms.RadioButton();
            this.rdbOutputCopy = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.chkSaveBackup = new System.Windows.Forms.CheckBox();
            this.lstFiles = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblReduceType = new System.Windows.Forms.Label();
            this.chkPreserveOrientation = new System.Windows.Forms.CheckBox();
            this.chkAspectRatio = new System.Windows.Forms.CheckBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectOutput = new System.Windows.Forms.Button();
            this.btnSelectInput = new System.Windows.Forms.Button();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.txtInputPath = new System.Windows.Forms.TextBox();
            this.chkOutputFolder = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.chkSeekRecursively = new System.Windows.Forms.CheckBox();
            this.chkFilterJPG = new System.Windows.Forms.CheckBox();
            this.chkFilterPNG = new System.Windows.Forms.CheckBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnRun = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCountInputs = new System.Windows.Forms.Panel();
            this.lblCountInputs = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlCountOutputs = new System.Windows.Forms.Panel();
            this.lblCountOutputs = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlCountInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCountOutputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Width = 400;
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlLine.Location = new System.Drawing.Point(17, 218);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(275, 3);
            this.pnlLine.TabIndex = 20;
            // 
            // lblFolderCount
            // 
            this.lblFolderCount.BackColor = System.Drawing.Color.Transparent;
            this.lblFolderCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFolderCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFolderCount.Font = new System.Drawing.Font("Roboto", 140.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFolderCount.ForeColor = System.Drawing.Color.Black;
            this.lblFolderCount.Location = new System.Drawing.Point(308, 411);
            this.lblFolderCount.Name = "lblFolderCount";
            this.lblFolderCount.Size = new System.Drawing.Size(656, 225);
            this.lblFolderCount.TabIndex = 10;
            this.lblFolderCount.Text = "0";
            this.lblFolderCount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblFolderCount.Visible = false;
            // 
            // rdbOutputPdf
            // 
            this.rdbOutputPdf.AutoSize = true;
            this.rdbOutputPdf.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbOutputPdf.Location = new System.Drawing.Point(31, 59);
            this.rdbOutputPdf.Name = "rdbOutputPdf";
            this.rdbOutputPdf.Size = new System.Drawing.Size(167, 23);
            this.rdbOutputPdf.TabIndex = 17;
            this.rdbOutputPdf.Text = "Consolidado em Pdf";
            this.toolTip1.SetToolTip(this.rdbOutputPdf, "Unifica todas as imagens da pasta de origem em um arquivo .Pdf de mesmo nome.");
            this.rdbOutputPdf.UseVisualStyleBackColor = true;
            this.rdbOutputPdf.CheckedChanged += new System.EventHandler(this.rdbOutputPdf_CheckedChanged);
            // 
            // rdbOutputCbz
            // 
            this.rdbOutputCbz.AutoSize = true;
            this.rdbOutputCbz.Checked = true;
            this.rdbOutputCbz.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbOutputCbz.Location = new System.Drawing.Point(31, 33);
            this.rdbOutputCbz.Name = "rdbOutputCbz";
            this.rdbOutputCbz.Size = new System.Drawing.Size(172, 23);
            this.rdbOutputCbz.TabIndex = 16;
            this.rdbOutputCbz.TabStop = true;
            this.rdbOutputCbz.Text = "Consolidado em Cbz";
            this.toolTip1.SetToolTip(this.rdbOutputCbz, "Unifica todas as imagens da pasta de origem em um arquivo .Cbz (padrão HQ) de mes" +
        "mo nome.\r\n");
            this.rdbOutputCbz.UseVisualStyleBackColor = true;
            this.rdbOutputCbz.CheckedChanged += new System.EventHandler(this.rdbOutputCbz_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(205, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "x";
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeight.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHeight.ForeColor = System.Drawing.Color.LightGray;
            this.txtHeight.Location = new System.Drawing.Point(224, 184);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(67, 24);
            this.txtHeight.TabIndex = 17;
            this.txtHeight.Text = "999999";
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // txtWidth
            // 
            this.txtWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWidth.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWidth.ForeColor = System.Drawing.Color.LightGray;
            this.txtWidth.Location = new System.Drawing.Point(135, 184);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(67, 24);
            this.txtWidth.TabIndex = 16;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            this.txtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWidth_KeyPress);
            // 
            // rdbPorcent
            // 
            this.rdbPorcent.AutoSize = true;
            this.rdbPorcent.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbPorcent.Location = new System.Drawing.Point(31, 151);
            this.rdbPorcent.Name = "rdbPorcent";
            this.rdbPorcent.Size = new System.Drawing.Size(121, 23);
            this.rdbPorcent.TabIndex = 15;
            this.rdbPorcent.Text = "Porcentagem";
            this.rdbPorcent.UseVisualStyleBackColor = true;
            this.rdbPorcent.CheckedChanged += new System.EventHandler(this.rdbPorcent_CheckedChanged);
            // 
            // rdbHQ
            // 
            this.rdbHQ.AutoSize = true;
            this.rdbHQ.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbHQ.Location = new System.Drawing.Point(31, 122);
            this.rdbHQ.Name = "rdbHQ";
            this.rdbHQ.Size = new System.Drawing.Size(179, 23);
            this.rdbHQ.TabIndex = 14;
            this.rdbHQ.Text = "HQ ( 720 x 1080 pixels)";
            this.rdbHQ.UseVisualStyleBackColor = true;
            this.rdbHQ.CheckedChanged += new System.EventHandler(this.rdbHQ_CheckedChanged);
            // 
            // rdbLarge
            // 
            this.rdbLarge.AutoSize = true;
            this.rdbLarge.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbLarge.Location = new System.Drawing.Point(31, 93);
            this.rdbLarge.Name = "rdbLarge";
            this.rdbLarge.Size = new System.Drawing.Size(219, 23);
            this.rdbLarge.TabIndex = 13;
            this.rdbLarge.Text = "Grande ( 1920 x 1080 pixels)";
            this.rdbLarge.UseVisualStyleBackColor = true;
            this.rdbLarge.CheckedChanged += new System.EventHandler(this.rdbLarge_CheckedChanged);
            // 
            // rdbMedium
            // 
            this.rdbMedium.AutoSize = true;
            this.rdbMedium.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbMedium.Location = new System.Drawing.Point(31, 64);
            this.rdbMedium.Name = "rdbMedium";
            this.rdbMedium.Size = new System.Drawing.Size(201, 23);
            this.rdbMedium.TabIndex = 12;
            this.rdbMedium.Text = "Médio ( 1366 x 768 pixels)";
            this.rdbMedium.UseVisualStyleBackColor = true;
            this.rdbMedium.CheckedChanged += new System.EventHandler(this.rdbMedium_CheckedChanged);
            // 
            // rdbSmall
            // 
            this.rdbSmall.AutoSize = true;
            this.rdbSmall.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbSmall.Location = new System.Drawing.Point(31, 35);
            this.rdbSmall.Name = "rdbSmall";
            this.rdbSmall.Size = new System.Drawing.Size(212, 23);
            this.rdbSmall.TabIndex = 11;
            this.rdbSmall.Text = "Pequeno ( 854 x 480 pixels)";
            this.rdbSmall.UseVisualStyleBackColor = true;
            this.rdbSmall.CheckedChanged += new System.EventHandler(this.rdbSmall_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Redimensionar";
            // 
            // picPreview
            // 
            this.picPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picPreview.Location = new System.Drawing.Point(745, 330);
            this.picPreview.Name = "picPreview";
            this.picPreview.Padding = new System.Windows.Forms.Padding(8);
            this.picPreview.Size = new System.Drawing.Size(200, 285);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 9;
            this.picPreview.TabStop = false;
            this.picPreview.Click += new System.EventHandler(this.picPreview_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdbOutputReplace);
            this.panel4.Controls.Add(this.rdbOutputCopy);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.chkSaveBackup);
            this.panel4.Controls.Add(this.rdbOutputPdf);
            this.panel4.Controls.Add(this.rdbOutputCbz);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 282);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(308, 172);
            this.panel4.TabIndex = 22;
            // 
            // rdbOutputReplace
            // 
            this.rdbOutputReplace.AutoSize = true;
            this.rdbOutputReplace.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbOutputReplace.Location = new System.Drawing.Point(31, 111);
            this.rdbOutputReplace.Name = "rdbOutputReplace";
            this.rdbOutputReplace.Size = new System.Drawing.Size(202, 23);
            this.rdbOutputReplace.TabIndex = 27;
            this.rdbOutputReplace.Text = "Substituir imagem original";
            this.toolTip1.SetToolTip(this.rdbOutputReplace, "Imagem original será substituida.");
            this.rdbOutputReplace.UseVisualStyleBackColor = true;
            this.rdbOutputReplace.CheckedChanged += new System.EventHandler(this.rdbOutputReplace_CheckedChanged);
            // 
            // rdbOutputCopy
            // 
            this.rdbOutputCopy.AutoSize = true;
            this.rdbOutputCopy.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbOutputCopy.Location = new System.Drawing.Point(31, 85);
            this.rdbOutputCopy.Name = "rdbOutputCopy";
            this.rdbOutputCopy.Size = new System.Drawing.Size(140, 23);
            this.rdbOutputCopy.TabIndex = 26;
            this.rdbOutputCopy.Text = "Criar uma cópia";
            this.toolTip1.SetToolTip(this.rdbOutputCopy, "Cópia será numerada, caso o destino selecionado seja o mesmo da imagem original.");
            this.rdbOutputCopy.UseVisualStyleBackColor = true;
            this.rdbOutputCopy.CheckedChanged += new System.EventHandler(this.rdbOutputCopy_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Opções de Saída";
            // 
            // chkSaveBackup
            // 
            this.chkSaveBackup.AutoSize = true;
            this.chkSaveBackup.Enabled = false;
            this.chkSaveBackup.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkSaveBackup.Location = new System.Drawing.Point(43, 137);
            this.chkSaveBackup.Name = "chkSaveBackup";
            this.chkSaveBackup.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.chkSaveBackup.Size = new System.Drawing.Size(201, 23);
            this.chkSaveBackup.TabIndex = 24;
            this.chkSaveBackup.Text = "Guardar Backup original";
            this.toolTip1.SetToolTip(this.chkSaveBackup, "Opção de armazenar imagem original na pasta \"__backup\" localizado dentro da pasta" +
        " origem das imagens");
            this.chkSaveBackup.UseVisualStyleBackColor = true;
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
            this.lstFiles.Location = new System.Drawing.Point(308, 244);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(656, 392);
            this.lstFiles.TabIndex = 8;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.View = System.Windows.Forms.View.Details;
            this.lstFiles.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstFiles_ItemSelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblReduceType);
            this.panel2.Controls.Add(this.chkPreserveOrientation);
            this.panel2.Controls.Add(this.chkAspectRatio);
            this.panel2.Controls.Add(this.pnlLine);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtHeight);
            this.panel2.Controls.Add(this.txtWidth);
            this.panel2.Controls.Add(this.rdbPorcent);
            this.panel2.Controls.Add(this.rdbHQ);
            this.panel2.Controls.Add(this.rdbLarge);
            this.panel2.Controls.Add(this.rdbMedium);
            this.panel2.Controls.Add(this.rdbSmall);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 282);
            this.panel2.TabIndex = 2;
            // 
            // lblReduceType
            // 
            this.lblReduceType.AutoSize = true;
            this.lblReduceType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReduceType.Location = new System.Drawing.Point(43, 188);
            this.lblReduceType.Name = "lblReduceType";
            this.lblReduceType.Size = new System.Drawing.Size(91, 17);
            this.lblReduceType.TabIndex = 23;
            this.lblReduceType.Text = "Dimensão % ";
            // 
            // chkPreserveOrientation
            // 
            this.chkPreserveOrientation.AutoSize = true;
            this.chkPreserveOrientation.Checked = true;
            this.chkPreserveOrientation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPreserveOrientation.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkPreserveOrientation.Location = new System.Drawing.Point(31, 253);
            this.chkPreserveOrientation.Name = "chkPreserveOrientation";
            this.chkPreserveOrientation.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.chkPreserveOrientation.Size = new System.Drawing.Size(261, 23);
            this.chkPreserveOrientation.TabIndex = 22;
            this.chkPreserveOrientation.Text = "Manter a orientação da imagem";
            this.chkPreserveOrientation.UseVisualStyleBackColor = true;
            // 
            // chkAspectRatio
            // 
            this.chkAspectRatio.AutoSize = true;
            this.chkAspectRatio.Checked = true;
            this.chkAspectRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAspectRatio.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkAspectRatio.Location = new System.Drawing.Point(31, 224);
            this.chkAspectRatio.Name = "chkAspectRatio";
            this.chkAspectRatio.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.chkAspectRatio.Size = new System.Drawing.Size(232, 23);
            this.chkAspectRatio.TabIndex = 21;
            this.chkAspectRatio.Text = "Manter a taxa de proporção";
            this.chkAspectRatio.UseVisualStyleBackColor = true;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Controls.Add(this.btnSelectOutput);
            this.pnlTop.Controls.Add(this.btnSelectInput);
            this.pnlTop.Controls.Add(this.txtOutputFolder);
            this.pnlTop.Controls.Add(this.txtInputPath);
            this.pnlTop.Controls.Add(this.chkOutputFolder);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.pnlFilter);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(964, 124);
            this.pnlTop.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Diretório de Destino";
            // 
            // btnSelectOutput
            // 
            this.btnSelectOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectOutput.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSelectOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectOutput.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelectOutput.Location = new System.Drawing.Point(918, 87);
            this.btnSelectOutput.Name = "btnSelectOutput";
            this.btnSelectOutput.Size = new System.Drawing.Size(30, 24);
            this.btnSelectOutput.TabIndex = 9;
            this.btnSelectOutput.Text = "...";
            this.btnSelectOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelectOutput.UseVisualStyleBackColor = true;
            this.btnSelectOutput.Click += new System.EventHandler(this.btnSelectOutput_Click);
            // 
            // btnSelectInput
            // 
            this.btnSelectInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectInput.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSelectInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectInput.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelectInput.Location = new System.Drawing.Point(918, 32);
            this.btnSelectInput.Name = "btnSelectInput";
            this.btnSelectInput.Size = new System.Drawing.Size(30, 24);
            this.btnSelectInput.TabIndex = 8;
            this.btnSelectInput.Text = "...";
            this.btnSelectInput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelectInput.UseVisualStyleBackColor = true;
            this.btnSelectInput.Click += new System.EventHandler(this.btnSelectInput_Click);
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtOutputFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutputFolder.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOutputFolder.ForeColor = System.Drawing.Color.DarkGray;
            this.txtOutputFolder.Location = new System.Drawing.Point(17, 87);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.PlaceholderText = "Destino da Imagem\'s";
            this.txtOutputFolder.Size = new System.Drawing.Size(902, 24);
            this.txtOutputFolder.TabIndex = 4;
            this.txtOutputFolder.DoubleClick += new System.EventHandler(this.txtOutputFolder_Enter);
            this.txtOutputFolder.Enter += new System.EventHandler(this.txtOutputFolder_Enter);
            this.txtOutputFolder.Leave += new System.EventHandler(this.txtOutputFolder_Leave);
            // 
            // txtInputPath
            // 
            this.txtInputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtInputPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInputPath.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInputPath.ForeColor = System.Drawing.Color.LightGray;
            this.txtInputPath.Location = new System.Drawing.Point(17, 32);
            this.txtInputPath.Name = "txtInputPath";
            this.txtInputPath.PlaceholderText = "Origem da Imagem\'s";
            this.txtInputPath.Size = new System.Drawing.Size(902, 24);
            this.txtInputPath.TabIndex = 3;
            this.txtInputPath.TextChanged += new System.EventHandler(this.txtInputPath_TextChanged);
            this.txtInputPath.DoubleClick += new System.EventHandler(this.txtInputPath_Enter);
            this.txtInputPath.Enter += new System.EventHandler(this.txtInputPath_Enter);
            // 
            // chkOutputFolder
            // 
            this.chkOutputFolder.AutoSize = true;
            this.chkOutputFolder.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkOutputFolder.Location = new System.Drawing.Point(175, 63);
            this.chkOutputFolder.Name = "chkOutputFolder";
            this.chkOutputFolder.Size = new System.Drawing.Size(133, 24);
            this.chkOutputFolder.TabIndex = 2;
            this.chkOutputFolder.Text = "alterar destino";
            this.chkOutputFolder.UseVisualStyleBackColor = true;
            this.chkOutputFolder.Visible = false;
            this.chkOutputFolder.CheckedChanged += new System.EventHandler(this.chkOutputFolder_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diretório de Origem e/ou Imagem";
            // 
            // pnlFilter
            // 
            this.pnlFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilter.Controls.Add(this.chkSeekRecursively);
            this.pnlFilter.Controls.Add(this.chkFilterJPG);
            this.pnlFilter.Controls.Add(this.chkFilterPNG);
            this.pnlFilter.Location = new System.Drawing.Point(641, 2);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(323, 27);
            this.pnlFilter.TabIndex = 1;
            this.pnlFilter.Visible = false;
            // 
            // chkSeekRecursively
            // 
            this.chkSeekRecursively.AutoSize = true;
            this.chkSeekRecursively.Checked = true;
            this.chkSeekRecursively.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSeekRecursively.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkSeekRecursively.Location = new System.Drawing.Point(9, 1);
            this.chkSeekRecursively.Name = "chkSeekRecursively";
            this.chkSeekRecursively.Size = new System.Drawing.Size(134, 23);
            this.chkSeekRecursively.TabIndex = 7;
            this.chkSeekRecursively.Tag = "";
            this.chkSeekRecursively.Text = "Busca recursiva";
            this.chkSeekRecursively.UseVisualStyleBackColor = true;
            // 
            // chkFilterJPG
            // 
            this.chkFilterJPG.AutoSize = true;
            this.chkFilterJPG.Checked = true;
            this.chkFilterJPG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFilterJPG.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkFilterJPG.Location = new System.Drawing.Point(182, 1);
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
            this.chkFilterPNG.Location = new System.Drawing.Point(251, 1);
            this.chkFilterPNG.Name = "chkFilterPNG";
            this.chkFilterPNG.Size = new System.Drawing.Size(60, 23);
            this.chkFilterPNG.TabIndex = 6;
            this.chkFilterPNG.Tag = "*.png";
            this.chkFilterPNG.Text = ".png";
            this.chkFilterPNG.UseVisualStyleBackColor = true;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlLeft.Controls.Add(this.panel4);
            this.pnlLeft.Controls.Add(this.btnRun);
            this.pnlLeft.Controls.Add(this.panel1);
            this.pnlLeft.Controls.Add(this.panel2);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 124);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(308, 512);
            this.pnlLeft.TabIndex = 6;
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
            this.btnRun.Location = new System.Drawing.Point(0, 458);
            this.btnRun.Margin = new System.Windows.Forms.Padding(5);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(308, 54);
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
            this.panel1.Size = new System.Drawing.Size(275, 3);
            this.panel1.TabIndex = 5;
            // 
            // progBar
            // 
            this.progBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progBar.Location = new System.Drawing.Point(0, 636);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(964, 5);
            this.progBar.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(308, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(656, 120);
            this.panel3.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlCountInputs, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlCountOutputs, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(656, 120);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlCountInputs
            // 
            this.pnlCountInputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnlCountInputs.Controls.Add(this.lblCountInputs);
            this.pnlCountInputs.Controls.Add(this.pictureBox1);
            this.pnlCountInputs.Controls.Add(this.label6);
            this.pnlCountInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCountInputs.Location = new System.Drawing.Point(0, 0);
            this.pnlCountInputs.Margin = new System.Windows.Forms.Padding(0, 0, 3, 6);
            this.pnlCountInputs.Name = "pnlCountInputs";
            this.pnlCountInputs.Size = new System.Drawing.Size(325, 114);
            this.pnlCountInputs.TabIndex = 0;
            // 
            // lblCountInputs
            // 
            this.lblCountInputs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountInputs.Font = new System.Drawing.Font("Roboto Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountInputs.ForeColor = System.Drawing.Color.Black;
            this.lblCountInputs.Location = new System.Drawing.Point(4, 41);
            this.lblCountInputs.Name = "lblCountInputs";
            this.lblCountInputs.Size = new System.Drawing.Size(242, 70);
            this.lblCountInputs.TabIndex = 2;
            this.lblCountInputs.Text = "0";
            this.lblCountInputs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(252, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 44);
            this.label6.TabIndex = 0;
            this.label6.Text = "Entradas";
            // 
            // pnlCountOutputs
            // 
            this.pnlCountOutputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnlCountOutputs.Controls.Add(this.lblCountOutputs);
            this.pnlCountOutputs.Controls.Add(this.label7);
            this.pnlCountOutputs.Controls.Add(this.pictureBox2);
            this.pnlCountOutputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCountOutputs.Location = new System.Drawing.Point(331, 0);
            this.pnlCountOutputs.Margin = new System.Windows.Forms.Padding(3, 0, 0, 6);
            this.pnlCountOutputs.Name = "pnlCountOutputs";
            this.pnlCountOutputs.Size = new System.Drawing.Size(325, 114);
            this.pnlCountOutputs.TabIndex = 1;
            // 
            // lblCountOutputs
            // 
            this.lblCountOutputs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountOutputs.Font = new System.Drawing.Font("Roboto Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountOutputs.ForeColor = System.Drawing.Color.Black;
            this.lblCountOutputs.Location = new System.Drawing.Point(5, 41);
            this.lblCountOutputs.Name = "lblCountOutputs";
            this.lblCountOutputs.Size = new System.Drawing.Size(242, 70);
            this.lblCountOutputs.TabIndex = 4;
            this.lblCountOutputs.Text = "0";
            this.lblCountOutputs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 44);
            this.label7.TabIndex = 3;
            this.label7.Text = "Saídas";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(252, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(964, 641);
            this.Controls.Add(this.lblFolderCount);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Redimensionar Imagens";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlCountInputs.ResumeLayout(false);
            this.pnlCountInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCountOutputs.ResumeLayout(false);
            this.pnlCountOutputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

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

