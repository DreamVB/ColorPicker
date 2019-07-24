namespace DmColorPicker
{
    partial class f
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f));
            this.PicPallete = new System.Windows.Forms.PictureBox();
            this.MnuPopup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuCube = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPencil = new System.Windows.Forms.ToolStripMenuItem();
            this.pColor = new System.Windows.Forms.PictureBox();
            this.pCustompal = new System.Windows.Forms.Panel();
            this.pColor8 = new System.Windows.Forms.PictureBox();
            this.pColor7 = new System.Windows.Forms.PictureBox();
            this.pColor6 = new System.Windows.Forms.PictureBox();
            this.pColor5 = new System.Windows.Forms.PictureBox();
            this.pColor4 = new System.Windows.Forms.PictureBox();
            this.pColor3 = new System.Windows.Forms.PictureBox();
            this.pColor2 = new System.Windows.Forms.PictureBox();
            this.pColor1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdInvert = new System.Windows.Forms.Button();
            this.cmdLight1 = new System.Windows.Forms.Button();
            this.cmdLight2 = new System.Windows.Forms.Button();
            this.cmdRandom = new System.Windows.Forms.Button();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdPickColor = new System.Windows.Forms.Button();
            this.cmdPicker = new System.Windows.Forms.Button();
            this.cmdCopyColVal = new System.Windows.Forms.Button();
            this.cmdAbout = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.LstColors = new System.Windows.Forms.ListBox();
            this.cboColors = new System.Windows.Forms.ComboBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.hsbRed = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hsbGreen = new System.Windows.Forms.HScrollBar();
            this.lblBlue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hsbBlue = new System.Windows.Forms.HScrollBar();
            this.lblLine = new System.Windows.Forms.Label();
            this.SBar1 = new System.Windows.Forms.Panel();
            this.lblVer = new System.Windows.Forms.Label();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.r3 = new System.Windows.Forms.RadioButton();
            this.r4 = new System.Windows.Forms.RadioButton();
            this.r5 = new System.Windows.Forms.RadioButton();
            this.r6 = new System.Windows.Forms.RadioButton();
            this.r7 = new System.Windows.Forms.RadioButton();
            this.r8 = new System.Windows.Forms.RadioButton();
            this.cmdAddCustom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicPallete)).BeginInit();
            this.MnuPopup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pColor)).BeginInit();
            this.pCustompal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pColor8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pColor7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pColor6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pColor5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pColor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pColor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pColor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pColor1)).BeginInit();
            this.SBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicPallete
            // 
            this.PicPallete.BackColor = System.Drawing.Color.Transparent;
            this.PicPallete.ContextMenuStrip = this.MnuPopup;
            this.PicPallete.Cursor = System.Windows.Forms.Cursors.Cross;
            this.PicPallete.Location = new System.Drawing.Point(9, 6);
            this.PicPallete.Name = "PicPallete";
            this.PicPallete.Size = new System.Drawing.Size(182, 159);
            this.PicPallete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicPallete.TabIndex = 0;
            this.PicPallete.TabStop = false;
            this.PicPallete.Tag = "windows.png";
            this.PicPallete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicPallete_MouseDown);
            this.PicPallete.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicPallete_MouseMove);
            this.PicPallete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicPallete_MouseUp);
            // 
            // MnuPopup
            // 
            this.MnuPopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCube,
            this.mnuWin,
            this.mnuPencil});
            this.MnuPopup.Name = "contextMenuStrip1";
            this.MnuPopup.Size = new System.Drawing.Size(124, 70);
            // 
            // mnuCube
            // 
            this.mnuCube.Name = "mnuCube";
            this.mnuCube.Size = new System.Drawing.Size(123, 22);
            this.mnuCube.Text = "Cube";
            this.mnuCube.Click += new System.EventHandler(this.mnuCube_Click);
            // 
            // mnuWin
            // 
            this.mnuWin.Name = "mnuWin";
            this.mnuWin.Size = new System.Drawing.Size(123, 22);
            this.mnuWin.Text = "Windows";
            this.mnuWin.Click += new System.EventHandler(this.mnuWin_Click);
            // 
            // mnuPencil
            // 
            this.mnuPencil.Name = "mnuPencil";
            this.mnuPencil.Size = new System.Drawing.Size(123, 22);
            this.mnuPencil.Text = "Pencils";
            this.mnuPencil.Click += new System.EventHandler(this.mnuPencil_Click);
            // 
            // pColor
            // 
            this.pColor.BackColor = System.Drawing.Color.Gray;
            this.pColor.Cursor = System.Windows.Forms.Cursors.Default;
            this.pColor.Location = new System.Drawing.Point(198, 6);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(70, 159);
            this.pColor.TabIndex = 7;
            this.pColor.TabStop = false;
            // 
            // pCustompal
            // 
            this.pCustompal.Controls.Add(this.pColor8);
            this.pCustompal.Controls.Add(this.pColor7);
            this.pCustompal.Controls.Add(this.pColor6);
            this.pCustompal.Controls.Add(this.pColor5);
            this.pCustompal.Controls.Add(this.pColor4);
            this.pCustompal.Controls.Add(this.pColor3);
            this.pCustompal.Controls.Add(this.pColor2);
            this.pCustompal.Controls.Add(this.pColor1);
            this.pCustompal.Location = new System.Drawing.Point(275, 100);
            this.pCustompal.Name = "pCustompal";
            this.pCustompal.Size = new System.Drawing.Size(272, 37);
            this.pCustompal.TabIndex = 11;
            // 
            // pColor8
            // 
            this.pColor8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pColor8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pColor8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pColor8.Location = new System.Drawing.Point(232, 5);
            this.pColor8.Name = "pColor8";
            this.pColor8.Size = new System.Drawing.Size(26, 24);
            this.pColor8.TabIndex = 7;
            this.pColor8.TabStop = false;
            this.pColor8.DoubleClick += new System.EventHandler(this.pColor1_DoubleClick);
            this.pColor8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColor1_MouseDown);
            // 
            // pColor7
            // 
            this.pColor7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pColor7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pColor7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pColor7.Location = new System.Drawing.Point(200, 5);
            this.pColor7.Name = "pColor7";
            this.pColor7.Size = new System.Drawing.Size(26, 24);
            this.pColor7.TabIndex = 6;
            this.pColor7.TabStop = false;
            this.pColor7.DoubleClick += new System.EventHandler(this.pColor1_DoubleClick);
            this.pColor7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColor1_MouseDown);
            // 
            // pColor6
            // 
            this.pColor6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pColor6.BackColor = System.Drawing.Color.Yellow;
            this.pColor6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pColor6.Location = new System.Drawing.Point(168, 5);
            this.pColor6.Name = "pColor6";
            this.pColor6.Size = new System.Drawing.Size(26, 24);
            this.pColor6.TabIndex = 5;
            this.pColor6.TabStop = false;
            this.pColor6.DoubleClick += new System.EventHandler(this.pColor1_DoubleClick);
            this.pColor6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColor1_MouseDown);
            // 
            // pColor5
            // 
            this.pColor5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pColor5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pColor5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pColor5.Location = new System.Drawing.Point(136, 5);
            this.pColor5.Name = "pColor5";
            this.pColor5.Size = new System.Drawing.Size(26, 24);
            this.pColor5.TabIndex = 4;
            this.pColor5.TabStop = false;
            this.pColor5.DoubleClick += new System.EventHandler(this.pColor1_DoubleClick);
            this.pColor5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColor1_MouseDown);
            // 
            // pColor4
            // 
            this.pColor4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pColor4.BackColor = System.Drawing.Color.Blue;
            this.pColor4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pColor4.Location = new System.Drawing.Point(104, 5);
            this.pColor4.Name = "pColor4";
            this.pColor4.Size = new System.Drawing.Size(26, 24);
            this.pColor4.TabIndex = 3;
            this.pColor4.TabStop = false;
            this.pColor4.DoubleClick += new System.EventHandler(this.pColor1_DoubleClick);
            this.pColor4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColor1_MouseDown);
            // 
            // pColor3
            // 
            this.pColor3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pColor3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pColor3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pColor3.Location = new System.Drawing.Point(72, 5);
            this.pColor3.Name = "pColor3";
            this.pColor3.Size = new System.Drawing.Size(26, 24);
            this.pColor3.TabIndex = 2;
            this.pColor3.TabStop = false;
            this.pColor3.DoubleClick += new System.EventHandler(this.pColor1_DoubleClick);
            this.pColor3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColor1_MouseDown);
            // 
            // pColor2
            // 
            this.pColor2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pColor2.BackColor = System.Drawing.Color.Red;
            this.pColor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pColor2.Location = new System.Drawing.Point(40, 5);
            this.pColor2.Name = "pColor2";
            this.pColor2.Size = new System.Drawing.Size(26, 24);
            this.pColor2.TabIndex = 1;
            this.pColor2.TabStop = false;
            this.pColor2.DoubleClick += new System.EventHandler(this.pColor1_DoubleClick);
            this.pColor2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColor1_MouseDown);
            // 
            // pColor1
            // 
            this.pColor1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pColor1.BackColor = System.Drawing.Color.Black;
            this.pColor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pColor1.Location = new System.Drawing.Point(8, 5);
            this.pColor1.Name = "pColor1";
            this.pColor1.Size = new System.Drawing.Size(26, 24);
            this.pColor1.TabIndex = 0;
            this.pColor1.TabStop = false;
            this.pColor1.DoubleClick += new System.EventHandler(this.pColor1_DoubleClick);
            this.pColor1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColor1_MouseDown);
            // 
            // cmdInvert
            // 
            this.cmdInvert.FlatAppearance.BorderSize = 0;
            this.cmdInvert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.cmdInvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(208)))));
            this.cmdInvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdInvert.Image = ((System.Drawing.Image)(resources.GetObject("cmdInvert.Image")));
            this.cmdInvert.Location = new System.Drawing.Point(107, 181);
            this.cmdInvert.Name = "cmdInvert";
            this.cmdInvert.Size = new System.Drawing.Size(32, 32);
            this.cmdInvert.TabIndex = 35;
            this.toolTip1.SetToolTip(this.cmdInvert, "Invert");
            this.cmdInvert.UseVisualStyleBackColor = true;
            this.cmdInvert.Click += new System.EventHandler(this.cmdInvert_Click);
            // 
            // cmdLight1
            // 
            this.cmdLight1.FlatAppearance.BorderSize = 0;
            this.cmdLight1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.cmdLight1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(208)))));
            this.cmdLight1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLight1.Image = ((System.Drawing.Image)(resources.GetObject("cmdLight1.Image")));
            this.cmdLight1.Location = new System.Drawing.Point(171, 181);
            this.cmdLight1.Name = "cmdLight1";
            this.cmdLight1.Size = new System.Drawing.Size(32, 32);
            this.cmdLight1.TabIndex = 37;
            this.toolTip1.SetToolTip(this.cmdLight1, "Lighten");
            this.cmdLight1.UseVisualStyleBackColor = true;
            this.cmdLight1.Click += new System.EventHandler(this.cmdLight1_Click);
            // 
            // cmdLight2
            // 
            this.cmdLight2.FlatAppearance.BorderSize = 0;
            this.cmdLight2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.cmdLight2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(208)))));
            this.cmdLight2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLight2.Image = ((System.Drawing.Image)(resources.GetObject("cmdLight2.Image")));
            this.cmdLight2.Location = new System.Drawing.Point(203, 181);
            this.cmdLight2.Name = "cmdLight2";
            this.cmdLight2.Size = new System.Drawing.Size(32, 32);
            this.cmdLight2.TabIndex = 38;
            this.toolTip1.SetToolTip(this.cmdLight2, "Darken");
            this.cmdLight2.UseVisualStyleBackColor = true;
            this.cmdLight2.Click += new System.EventHandler(this.cmdLight2_Click);
            // 
            // cmdRandom
            // 
            this.cmdRandom.FlatAppearance.BorderSize = 0;
            this.cmdRandom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.cmdRandom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(208)))));
            this.cmdRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRandom.Image = ((System.Drawing.Image)(resources.GetObject("cmdRandom.Image")));
            this.cmdRandom.Location = new System.Drawing.Point(324, 181);
            this.cmdRandom.Name = "cmdRandom";
            this.cmdRandom.Size = new System.Drawing.Size(32, 32);
            this.cmdRandom.TabIndex = 39;
            this.toolTip1.SetToolTip(this.cmdRandom, "Random Color");
            this.cmdRandom.UseVisualStyleBackColor = true;
            this.cmdRandom.Click += new System.EventHandler(this.cmdRandom_Click);
            // 
            // cmdOpen
            // 
            this.cmdOpen.FlatAppearance.BorderSize = 0;
            this.cmdOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.cmdOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(208)))));
            this.cmdOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdOpen.Image = ((System.Drawing.Image)(resources.GetObject("cmdOpen.Image")));
            this.cmdOpen.Location = new System.Drawing.Point(8, 181);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(32, 32);
            this.cmdOpen.TabIndex = 40;
            this.toolTip1.SetToolTip(this.cmdOpen, "Load custom colors");
            this.cmdOpen.UseVisualStyleBackColor = true;
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.FlatAppearance.BorderSize = 0;
            this.cmdSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.cmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(208)))));
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSave.Image = ((System.Drawing.Image)(resources.GetObject("cmdSave.Image")));
            this.cmdSave.Location = new System.Drawing.Point(40, 181);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(32, 32);
            this.cmdSave.TabIndex = 41;
            this.toolTip1.SetToolTip(this.cmdSave, "Save custom colors");
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdPickColor
            // 
            this.cmdPickColor.FlatAppearance.BorderSize = 0;
            this.cmdPickColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.cmdPickColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(208)))));
            this.cmdPickColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPickColor.Image = ((System.Drawing.Image)(resources.GetObject("cmdPickColor.Image")));
            this.cmdPickColor.Location = new System.Drawing.Point(292, 181);
            this.cmdPickColor.Name = "cmdPickColor";
            this.cmdPickColor.Size = new System.Drawing.Size(32, 32);
            this.cmdPickColor.TabIndex = 42;
            this.toolTip1.SetToolTip(this.cmdPickColor, "Pick Color");
            this.cmdPickColor.UseVisualStyleBackColor = true;
            this.cmdPickColor.Click += new System.EventHandler(this.cmdPickColor_Click);
            // 
            // cmdPicker
            // 
            this.cmdPicker.FlatAppearance.BorderSize = 0;
            this.cmdPicker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.cmdPicker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(208)))));
            this.cmdPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPicker.Image = ((System.Drawing.Image)(resources.GetObject("cmdPicker.Image")));
            this.cmdPicker.Location = new System.Drawing.Point(139, 181);
            this.cmdPicker.Name = "cmdPicker";
            this.cmdPicker.Size = new System.Drawing.Size(32, 32);
            this.cmdPicker.TabIndex = 43;
            this.toolTip1.SetToolTip(this.cmdPicker, "Color From Screen");
            this.cmdPicker.UseVisualStyleBackColor = true;
            this.cmdPicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdPicker_MouseDown);
            this.cmdPicker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmdPicker_MouseMove);
            this.cmdPicker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cmdPicker_MouseUp);
            // 
            // cmdCopyColVal
            // 
            this.cmdCopyColVal.FlatAppearance.BorderSize = 0;
            this.cmdCopyColVal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.cmdCopyColVal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(208)))));
            this.cmdCopyColVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCopyColVal.Image = ((System.Drawing.Image)(resources.GetObject("cmdCopyColVal.Image")));
            this.cmdCopyColVal.Location = new System.Drawing.Point(72, 181);
            this.cmdCopyColVal.Name = "cmdCopyColVal";
            this.cmdCopyColVal.Size = new System.Drawing.Size(32, 32);
            this.cmdCopyColVal.TabIndex = 44;
            this.toolTip1.SetToolTip(this.cmdCopyColVal, "Copy Color Value");
            this.cmdCopyColVal.UseVisualStyleBackColor = true;
            this.cmdCopyColVal.Click += new System.EventHandler(this.cmdCopyColVal_Click);
            // 
            // cmdAbout
            // 
            this.cmdAbout.FlatAppearance.BorderSize = 0;
            this.cmdAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.cmdAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(208)))));
            this.cmdAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAbout.Image = ((System.Drawing.Image)(resources.GetObject("cmdAbout.Image")));
            this.cmdAbout.Location = new System.Drawing.Point(661, 181);
            this.cmdAbout.Name = "cmdAbout";
            this.cmdAbout.Size = new System.Drawing.Size(32, 32);
            this.cmdAbout.TabIndex = 47;
            this.toolTip1.SetToolTip(this.cmdAbout, "About");
            this.cmdAbout.UseVisualStyleBackColor = true;
            this.cmdAbout.Click += new System.EventHandler(this.cmdAbout_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.FlatAppearance.BorderSize = 0;
            this.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(208)))));
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Image = ((System.Drawing.Image)(resources.GetObject("cmdClose.Image")));
            this.cmdClose.Location = new System.Drawing.Point(696, 181);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(32, 32);
            this.cmdClose.TabIndex = 48;
            this.toolTip1.SetToolTip(this.cmdClose, "Close");
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // LstColors
            // 
            this.LstColors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.LstColors.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstColors.FormattingEnabled = true;
            this.LstColors.IntegralHeight = false;
            this.LstColors.Location = new System.Drawing.Point(549, 37);
            this.LstColors.Name = "LstColors";
            this.LstColors.Size = new System.Drawing.Size(176, 128);
            this.LstColors.TabIndex = 14;
            this.LstColors.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.LstColors_DrawItem);
            this.LstColors.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.LstColors_MeasureItem);
            this.LstColors.SelectedIndexChanged += new System.EventHandler(this.LstColors_SelectedIndexChanged);
            // 
            // cboColors
            // 
            this.cboColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboColors.FormattingEnabled = true;
            this.cboColors.Items.AddRange(new object[] {
            "RGB",
            "RGB Float",
            "HEX",
            "WEB",
            "CSharp RGB",
            "Visual Basic Hex",
            "Visual Basic Long",
            "Visual C++ Hex"});
            this.cboColors.Location = new System.Drawing.Point(549, 8);
            this.cboColors.Name = "cboColors";
            this.cboColors.Size = new System.Drawing.Size(176, 24);
            this.cboColors.TabIndex = 21;
            this.cboColors.SelectedIndexChanged += new System.EventHandler(this.cboColors_SelectedIndexChanged);
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.White;
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(281, 141);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(252, 24);
            this.txtColor.TabIndex = 22;
            // 
            // hsbRed
            // 
            this.hsbRed.LargeChange = 1;
            this.hsbRed.Location = new System.Drawing.Point(329, 9);
            this.hsbRed.Maximum = 255;
            this.hsbRed.Name = "hsbRed";
            this.hsbRed.Size = new System.Drawing.Size(176, 13);
            this.hsbRed.TabIndex = 24;
            this.hsbRed.ValueChanged += new System.EventHandler(this.hsbBlue_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "RED:";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(509, 9);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(25, 13);
            this.lblRed.TabIndex = 26;
            this.lblRed.Text = "255";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(509, 33);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(25, 13);
            this.lblGreen.TabIndex = 29;
            this.lblGreen.Text = "255";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(275, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "GREEN";
            // 
            // hsbGreen
            // 
            this.hsbGreen.LargeChange = 1;
            this.hsbGreen.Location = new System.Drawing.Point(329, 33);
            this.hsbGreen.Maximum = 255;
            this.hsbGreen.Name = "hsbGreen";
            this.hsbGreen.Size = new System.Drawing.Size(176, 13);
            this.hsbGreen.TabIndex = 27;
            this.hsbGreen.ValueChanged += new System.EventHandler(this.hsbBlue_ValueChanged);
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(509, 57);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(25, 13);
            this.lblBlue.TabIndex = 32;
            this.lblBlue.Text = "255";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(275, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "BLUE";
            // 
            // hsbBlue
            // 
            this.hsbBlue.LargeChange = 1;
            this.hsbBlue.Location = new System.Drawing.Point(329, 57);
            this.hsbBlue.Maximum = 255;
            this.hsbBlue.Name = "hsbBlue";
            this.hsbBlue.Size = new System.Drawing.Size(176, 13);
            this.hsbBlue.TabIndex = 30;
            this.hsbBlue.ValueChanged += new System.EventHandler(this.hsbBlue_ValueChanged);
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.Color.DarkGray;
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(-26, 173);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(760, 2);
            this.lblLine.TabIndex = 34;
            // 
            // SBar1
            // 
            this.SBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.SBar1.Controls.Add(this.lblVer);
            this.SBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SBar1.Location = new System.Drawing.Point(0, 220);
            this.SBar1.Name = "SBar1";
            this.SBar1.Size = new System.Drawing.Size(733, 24);
            this.SBar1.TabIndex = 45;
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.ForeColor = System.Drawing.Color.White;
            this.lblVer.Location = new System.Drawing.Point(7, 6);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(60, 13);
            this.lblVer.TabIndex = 0;
            this.lblVer.Text = "Version 1.0";
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Checked = true;
            this.r1.FlatAppearance.BorderSize = 0;
            this.r1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r1.Location = new System.Drawing.Point(290, 82);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(13, 12);
            this.r1.TabIndex = 49;
            this.r1.TabStop = true;
            this.r1.Tag = "1";
            this.r1.UseVisualStyleBackColor = true;
            this.r1.Click += new System.EventHandler(this.r8_Click);
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.FlatAppearance.BorderSize = 0;
            this.r2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r2.Location = new System.Drawing.Point(322, 82);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(13, 12);
            this.r2.TabIndex = 50;
            this.r2.Tag = "2";
            this.r2.UseVisualStyleBackColor = true;
            this.r2.Click += new System.EventHandler(this.r8_Click);
            // 
            // r3
            // 
            this.r3.AutoSize = true;
            this.r3.FlatAppearance.BorderSize = 0;
            this.r3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r3.Location = new System.Drawing.Point(354, 82);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(13, 12);
            this.r3.TabIndex = 51;
            this.r3.Tag = "3";
            this.r3.UseVisualStyleBackColor = true;
            this.r3.Click += new System.EventHandler(this.r8_Click);
            // 
            // r4
            // 
            this.r4.AutoSize = true;
            this.r4.FlatAppearance.BorderSize = 0;
            this.r4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r4.Location = new System.Drawing.Point(386, 82);
            this.r4.Name = "r4";
            this.r4.Size = new System.Drawing.Size(13, 12);
            this.r4.TabIndex = 52;
            this.r4.Tag = "4";
            this.r4.UseVisualStyleBackColor = true;
            this.r4.Click += new System.EventHandler(this.r8_Click);
            // 
            // r5
            // 
            this.r5.AutoSize = true;
            this.r5.FlatAppearance.BorderSize = 0;
            this.r5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r5.Location = new System.Drawing.Point(418, 82);
            this.r5.Name = "r5";
            this.r5.Size = new System.Drawing.Size(13, 12);
            this.r5.TabIndex = 53;
            this.r5.Tag = "5";
            this.r5.UseVisualStyleBackColor = true;
            this.r5.Click += new System.EventHandler(this.r8_Click);
            // 
            // r6
            // 
            this.r6.AutoSize = true;
            this.r6.FlatAppearance.BorderSize = 0;
            this.r6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r6.Location = new System.Drawing.Point(450, 82);
            this.r6.Name = "r6";
            this.r6.Size = new System.Drawing.Size(13, 12);
            this.r6.TabIndex = 54;
            this.r6.Tag = "6";
            this.r6.UseVisualStyleBackColor = true;
            this.r6.Click += new System.EventHandler(this.r8_Click);
            // 
            // r7
            // 
            this.r7.AutoSize = true;
            this.r7.FlatAppearance.BorderSize = 0;
            this.r7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r7.Location = new System.Drawing.Point(482, 82);
            this.r7.Name = "r7";
            this.r7.Size = new System.Drawing.Size(13, 12);
            this.r7.TabIndex = 55;
            this.r7.Tag = "7";
            this.r7.UseVisualStyleBackColor = true;
            this.r7.Click += new System.EventHandler(this.r8_Click);
            // 
            // r8
            // 
            this.r8.AutoSize = true;
            this.r8.FlatAppearance.BorderSize = 0;
            this.r8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r8.Location = new System.Drawing.Point(514, 82);
            this.r8.Name = "r8";
            this.r8.Size = new System.Drawing.Size(13, 12);
            this.r8.TabIndex = 56;
            this.r8.Tag = "8";
            this.r8.UseVisualStyleBackColor = true;
            this.r8.Click += new System.EventHandler(this.r8_Click);
            // 
            // cmdAddCustom
            // 
            this.cmdAddCustom.FlatAppearance.BorderSize = 0;
            this.cmdAddCustom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.cmdAddCustom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(208)))));
            this.cmdAddCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAddCustom.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddCustom.Image")));
            this.cmdAddCustom.Location = new System.Drawing.Point(264, 181);
            this.cmdAddCustom.Name = "cmdAddCustom";
            this.cmdAddCustom.Size = new System.Drawing.Size(32, 32);
            this.cmdAddCustom.TabIndex = 57;
            this.toolTip1.SetToolTip(this.cmdAddCustom, "Add to custom colors");
            this.cmdAddCustom.UseVisualStyleBackColor = true;
            this.cmdAddCustom.Click += new System.EventHandler(this.cmdAddCustom_Click);
            // 
            // f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(733, 244);
            this.Controls.Add(this.cmdAddCustom);
            this.Controls.Add(this.r8);
            this.Controls.Add(this.r7);
            this.Controls.Add(this.r6);
            this.Controls.Add(this.r5);
            this.Controls.Add(this.r4);
            this.Controls.Add(this.r3);
            this.Controls.Add(this.r2);
            this.Controls.Add(this.r1);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdAbout);
            this.Controls.Add(this.SBar1);
            this.Controls.Add(this.cmdCopyColVal);
            this.Controls.Add(this.cmdPicker);
            this.Controls.Add(this.cmdPickColor);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdOpen);
            this.Controls.Add(this.cmdRandom);
            this.Controls.Add(this.cmdLight2);
            this.Controls.Add(this.cmdLight1);
            this.Controls.Add(this.cmdInvert);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hsbBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hsbGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hsbRed);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.cboColors);
            this.Controls.Add(this.LstColors);
            this.Controls.Add(this.pCustompal);
            this.Controls.Add(this.pColor);
            this.Controls.Add(this.PicPallete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "f";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DM Color Picker.NET Pro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicPallete)).EndInit();
            this.MnuPopup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pColor)).EndInit();
            this.pCustompal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pColor8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pColor7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pColor6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pColor5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pColor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pColor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pColor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pColor1)).EndInit();
            this.SBar1.ResumeLayout(false);
            this.SBar1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicPallete;
        private System.Windows.Forms.PictureBox pColor;
        private System.Windows.Forms.Panel pCustompal;
        private System.Windows.Forms.PictureBox pColor8;
        private System.Windows.Forms.PictureBox pColor7;
        private System.Windows.Forms.PictureBox pColor6;
        private System.Windows.Forms.PictureBox pColor5;
        private System.Windows.Forms.PictureBox pColor4;
        private System.Windows.Forms.PictureBox pColor3;
        private System.Windows.Forms.PictureBox pColor2;
        private System.Windows.Forms.PictureBox pColor1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox LstColors;
        private System.Windows.Forms.ComboBox cboColors;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.HScrollBar hsbRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar hsbGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar hsbBlue;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Button cmdInvert;
        private System.Windows.Forms.Button cmdLight1;
        private System.Windows.Forms.Button cmdLight2;
        private System.Windows.Forms.Button cmdRandom;
        private System.Windows.Forms.Button cmdOpen;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdPickColor;
        private System.Windows.Forms.Button cmdPicker;
        private System.Windows.Forms.ContextMenuStrip MnuPopup;
        private System.Windows.Forms.ToolStripMenuItem mnuCube;
        private System.Windows.Forms.ToolStripMenuItem mnuWin;
        private System.Windows.Forms.ToolStripMenuItem mnuPencil;
        private System.Windows.Forms.Button cmdCopyColVal;
        private System.Windows.Forms.Panel SBar1;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.Button cmdAbout;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.RadioButton r3;
        private System.Windows.Forms.RadioButton r4;
        private System.Windows.Forms.RadioButton r5;
        private System.Windows.Forms.RadioButton r6;
        private System.Windows.Forms.RadioButton r7;
        private System.Windows.Forms.RadioButton r8;
        private System.Windows.Forms.Button cmdAddCustom;
    }
}

