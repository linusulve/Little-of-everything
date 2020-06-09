namespace WindowsFormsApp14
{
    partial class Form1
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
            this.rtfDokument = new System.Windows.Forms.RichTextBox();
            this.btnTeckenSnitt = new System.Windows.Forms.Button();
            this.rdnRight = new System.Windows.Forms.RadioButton();
            this.rbnCenter = new System.Windows.Forms.RadioButton();
            this.rbnLeft = new System.Windows.Forms.RadioButton();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnGrön = new System.Windows.Forms.Button();
            this.btnRöd = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnPurple = new System.Windows.Forms.Button();
            this.rbnF = new System.Windows.Forms.RadioButton();
            this.rbnK = new System.Windows.Forms.RadioButton();
            this.nudFont = new System.Windows.Forms.NumericUpDown();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.cbxTeckenSnitt = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudFont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtfDokument
            // 
            this.rtfDokument.Location = new System.Drawing.Point(12, 69);
            this.rtfDokument.Name = "rtfDokument";
            this.rtfDokument.Size = new System.Drawing.Size(709, 207);
            this.rtfDokument.TabIndex = 0;
            this.rtfDokument.Text = "";
            this.rtfDokument.TextChanged += new System.EventHandler(this.rtfDokument_TextChanged);
            // 
            // btnTeckenSnitt
            // 
            this.btnTeckenSnitt.Location = new System.Drawing.Point(520, 40);
            this.btnTeckenSnitt.Name = "btnTeckenSnitt";
            this.btnTeckenSnitt.Size = new System.Drawing.Size(75, 23);
            this.btnTeckenSnitt.TabIndex = 1;
            this.btnTeckenSnitt.Text = "Teckensnitt";
            this.btnTeckenSnitt.UseVisualStyleBackColor = true;
            this.btnTeckenSnitt.Click += new System.EventHandler(this.btnTeckenSnitt_Click);
            // 
            // rdnRight
            // 
            this.rdnRight.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdnRight.BackgroundImage = global::WindowsFormsApp14.Properties.Resources.Höger;
            this.rdnRight.Location = new System.Drawing.Point(338, 10);
            this.rdnRight.Name = "rdnRight";
            this.rdnRight.Size = new System.Drawing.Size(28, 29);
            this.rdnRight.TabIndex = 4;
            this.rdnRight.UseVisualStyleBackColor = true;
            this.rdnRight.CheckedChanged += new System.EventHandler(this.rdnRight_CheckedChanged);
            // 
            // rbnCenter
            // 
            this.rbnCenter.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnCenter.BackgroundImage = global::WindowsFormsApp14.Properties.Resources.Center;
            this.rbnCenter.Location = new System.Drawing.Point(302, 10);
            this.rbnCenter.Name = "rbnCenter";
            this.rbnCenter.Size = new System.Drawing.Size(30, 29);
            this.rbnCenter.TabIndex = 3;
            this.rbnCenter.UseVisualStyleBackColor = true;
            this.rbnCenter.CheckedChanged += new System.EventHandler(this.rbnCenter_CheckedChanged);
            // 
            // rbnLeft
            // 
            this.rbnLeft.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnLeft.BackgroundImage = global::WindowsFormsApp14.Properties.Resources.Vänster;
            this.rbnLeft.Location = new System.Drawing.Point(266, 10);
            this.rbnLeft.Name = "rbnLeft";
            this.rbnLeft.Size = new System.Drawing.Size(30, 29);
            this.rbnLeft.TabIndex = 2;
            this.rbnLeft.UseVisualStyleBackColor = true;
            this.rbnLeft.CheckedChanged += new System.EventHandler(this.rbnLeft_CheckedChanged);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnColor.Location = new System.Drawing.Point(441, 10);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(27, 29);
            this.btnColor.TabIndex = 5;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnGrön
            // 
            this.btnGrön.BackColor = System.Drawing.Color.Green;
            this.btnGrön.Location = new System.Drawing.Point(505, 9);
            this.btnGrön.Name = "btnGrön";
            this.btnGrön.Size = new System.Drawing.Size(25, 30);
            this.btnGrön.TabIndex = 7;
            this.btnGrön.UseVisualStyleBackColor = false;
            this.btnGrön.Click += new System.EventHandler(this.btnGrön_Click);
            // 
            // btnRöd
            // 
            this.btnRöd.BackColor = System.Drawing.Color.Red;
            this.btnRöd.Location = new System.Drawing.Point(474, 9);
            this.btnRöd.Name = "btnRöd";
            this.btnRöd.Size = new System.Drawing.Size(25, 30);
            this.btnRöd.TabIndex = 8;
            this.btnRöd.UseVisualStyleBackColor = false;
            this.btnRöd.Click += new System.EventHandler(this.btnRöd_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Location = new System.Drawing.Point(567, 9);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(25, 27);
            this.btnYellow.TabIndex = 9;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPurple
            // 
            this.btnPurple.BackColor = System.Drawing.Color.Purple;
            this.btnPurple.Location = new System.Drawing.Point(536, 9);
            this.btnPurple.Name = "btnPurple";
            this.btnPurple.Size = new System.Drawing.Size(25, 30);
            this.btnPurple.TabIndex = 10;
            this.btnPurple.UseVisualStyleBackColor = false;
            this.btnPurple.Click += new System.EventHandler(this.btnPurple_Click);
            // 
            // rbnF
            // 
            this.rbnF.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnF.AutoSize = true;
            this.rbnF.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnF.Location = new System.Drawing.Point(191, 12);
            this.rbnF.Name = "rbnF";
            this.rbnF.Size = new System.Drawing.Size(24, 23);
            this.rbnF.TabIndex = 13;
            this.rbnF.TabStop = true;
            this.rbnF.Text = "F";
            this.rbnF.UseVisualStyleBackColor = true;
            this.rbnF.CheckedChanged += new System.EventHandler(this.rbnF_CheckedChanged);
            // 
            // rbnK
            // 
            this.rbnK.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnK.AutoSize = true;
            this.rbnK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnK.Location = new System.Drawing.Point(220, 13);
            this.rbnK.Name = "rbnK";
            this.rbnK.Size = new System.Drawing.Size(24, 23);
            this.rbnK.TabIndex = 14;
            this.rbnK.TabStop = true;
            this.rbnK.Text = "K";
            this.rbnK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbnK.UseVisualStyleBackColor = true;
            this.rbnK.CheckedChanged += new System.EventHandler(this.rbnK_CheckedChanged);
            // 
            // nudFont
            // 
            this.nudFont.Location = new System.Drawing.Point(139, 13);
            this.nudFont.Name = "nudFont";
            this.nudFont.Size = new System.Drawing.Size(37, 20);
            this.nudFont.TabIndex = 16;
            this.nudFont.ValueChanged += new System.EventHandler(this.nudFont_ValueChanged);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(627, 9);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(70, 20);
            this.tbxSearch.TabIndex = 17;
            this.tbxSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(627, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(568, 279);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(129, 23);
            this.trackBar1.TabIndex = 19;
            // 
            // cbxTeckenSnitt
            // 
            this.cbxTeckenSnitt.FormattingEnabled = true;
            this.cbxTeckenSnitt.Location = new System.Drawing.Point(12, 13);
            this.cbxTeckenSnitt.Name = "cbxTeckenSnitt";
            this.cbxTeckenSnitt.Size = new System.Drawing.Size(121, 21);
            this.cbxTeckenSnitt.TabIndex = 15;
            this.cbxTeckenSnitt.SelectedIndexChanged += new System.EventHandler(this.cbxTeckenSnitt_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(441, 40);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 23);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(733, 301);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.nudFont);
            this.Controls.Add(this.cbxTeckenSnitt);
            this.Controls.Add(this.rbnK);
            this.Controls.Add(this.rbnF);
            this.Controls.Add(this.btnPurple);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnRöd);
            this.Controls.Add(this.btnGrön);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.rdnRight);
            this.Controls.Add(this.rbnCenter);
            this.Controls.Add(this.rbnLeft);
            this.Controls.Add(this.btnTeckenSnitt);
            this.Controls.Add(this.rtfDokument);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudFont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfDokument;
        private System.Windows.Forms.Button btnTeckenSnitt;
        private System.Windows.Forms.RadioButton rbnLeft;
        private System.Windows.Forms.RadioButton rbnCenter;
        private System.Windows.Forms.RadioButton rdnRight;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnGrön;
        private System.Windows.Forms.Button btnRöd;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnPurple;
        private System.Windows.Forms.RadioButton rbnF;
        private System.Windows.Forms.RadioButton rbnK;
        private System.Windows.Forms.NumericUpDown nudFont;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ComboBox cbxTeckenSnitt;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

