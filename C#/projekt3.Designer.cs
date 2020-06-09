namespace WindowsFormsApp15
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
            this.rtxText = new System.Windows.Forms.RichTextBox();
            this.btnTeckenSnitt = new System.Windows.Forms.Button();
            this.rbnRight = new System.Windows.Forms.RadioButton();
            this.rbnCenter = new System.Windows.Forms.RadioButton();
            this.rdnLeft = new System.Windows.Forms.RadioButton();
            this.lblColor = new System.Windows.Forms.Label();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cmbTeckenSnitt = new System.Windows.Forms.ToolStripComboBox();
            this.nudkSize = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudkSize)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxText
            // 
            this.rtxText.Location = new System.Drawing.Point(12, 79);
            this.rtxText.Name = "rtxText";
            this.rtxText.Size = new System.Drawing.Size(709, 280);
            this.rtxText.TabIndex = 0;
            this.rtxText.Text = "";
            // 
            // btnTeckenSnitt
            // 
            this.btnTeckenSnitt.Location = new System.Drawing.Point(417, 50);
            this.btnTeckenSnitt.Name = "btnTeckenSnitt";
            this.btnTeckenSnitt.Size = new System.Drawing.Size(75, 23);
            this.btnTeckenSnitt.TabIndex = 1;
            this.btnTeckenSnitt.Text = "Teckensnitt";
            this.btnTeckenSnitt.UseVisualStyleBackColor = true;
            this.btnTeckenSnitt.Click += new System.EventHandler(this.btnTeckenSnitt_Click);
            // 
            // rbnRight
            // 
            this.rbnRight.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnRight.BackgroundImage = global::WindowsFormsApp15.Properties.Resources.Höger;
            this.rbnRight.Location = new System.Drawing.Point(480, 19);
            this.rbnRight.Name = "rbnRight";
            this.rbnRight.Size = new System.Drawing.Size(27, 28);
            this.rbnRight.TabIndex = 4;
            this.rbnRight.UseVisualStyleBackColor = true;
            this.rbnRight.CheckedChanged += new System.EventHandler(this.rbnRight_CheckedChanged);
            // 
            // rbnCenter
            // 
            this.rbnCenter.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnCenter.BackgroundImage = global::WindowsFormsApp15.Properties.Resources.Center;
            this.rbnCenter.Location = new System.Drawing.Point(448, 19);
            this.rbnCenter.Name = "rbnCenter";
            this.rbnCenter.Size = new System.Drawing.Size(26, 28);
            this.rbnCenter.TabIndex = 3;
            this.rbnCenter.UseVisualStyleBackColor = true;
            this.rbnCenter.CheckedChanged += new System.EventHandler(this.rbnCenter_CheckedChanged);
            // 
            // rdnLeft
            // 
            this.rdnLeft.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdnLeft.BackgroundImage = global::WindowsFormsApp15.Properties.Resources.Vänster;
            this.rdnLeft.Location = new System.Drawing.Point(417, 19);
            this.rdnLeft.Name = "rdnLeft";
            this.rdnLeft.Size = new System.Drawing.Size(25, 28);
            this.rdnLeft.TabIndex = 2;
            this.rdnLeft.UseVisualStyleBackColor = true;
            this.rdnLeft.CheckedChanged += new System.EventHandler(this.rdnLeft_CheckedChanged);
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblColor.Location = new System.Drawing.Point(549, 17);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(28, 28);
            this.lblColor.TabIndex = 5;
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbTeckenSnitt});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 27);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cmbTeckenSnitt
            // 
            this.cmbTeckenSnitt.Name = "cmbTeckenSnitt";
            this.cmbTeckenSnitt.Size = new System.Drawing.Size(121, 23);
            this.cmbTeckenSnitt.Click += new System.EventHandler(this.toolStripComboBox1_Click_1);
            // 
            // nudkSize
            // 
            this.nudkSize.Location = new System.Drawing.Point(141, 7);
            this.nudkSize.Name = "nudkSize";
            this.nudkSize.Size = new System.Drawing.Size(36, 20);
            this.nudkSize.TabIndex = 7;
            this.nudkSize.ValueChanged += new System.EventHandler(this.nudkSize_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 371);
            this.Controls.Add(this.nudkSize);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.rbnRight);
            this.Controls.Add(this.rbnCenter);
            this.Controls.Add(this.rdnLeft);
            this.Controls.Add(this.btnTeckenSnitt);
            this.Controls.Add(this.rtxText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudkSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxText;
        private System.Windows.Forms.Button btnTeckenSnitt;
        private System.Windows.Forms.RadioButton rdnLeft;
        private System.Windows.Forms.RadioButton rbnCenter;
        private System.Windows.Forms.RadioButton rbnRight;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox cmbTeckenSnitt;
        private System.Windows.Forms.NumericUpDown nudkSize;
    }
}

