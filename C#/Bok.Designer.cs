namespace WindowsFormsApp10
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBok = new System.Windows.Forms.Button();
            this.tbxBokSidor = new System.Windows.Forms.TextBox();
            this.tbxBokTitel = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLjud = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxLjudSpelTid = new System.Windows.Forms.TextBox();
            this.tbxLjudTitel = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFilm = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbxFilmSpelTid = new System.Windows.Forms.TextBox();
            this.tbxFilmTitel = new System.Windows.Forms.TextBox();
            this.lbxBibliotek = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Antal sidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speltid";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Titel";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Upplösning";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Speltid";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Titel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBok);
            this.groupBox1.Controls.Add(this.tbxBokSidor);
            this.groupBox1.Controls.Add(this.tbxBokTitel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 130);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bok";
            // 
            // btnBok
            // 
            this.btnBok.Location = new System.Drawing.Point(30, 101);
            this.btnBok.Name = "btnBok";
            this.btnBok.Size = new System.Drawing.Size(75, 23);
            this.btnBok.TabIndex = 3;
            this.btnBok.Text = "Bok";
            this.btnBok.UseVisualStyleBackColor = true;
            this.btnBok.Click += new System.EventHandler(this.btnBok_Click);
            // 
            // tbxBokSidor
            // 
            this.tbxBokSidor.Location = new System.Drawing.Point(69, 64);
            this.tbxBokSidor.Name = "tbxBokSidor";
            this.tbxBokSidor.Size = new System.Drawing.Size(61, 20);
            this.tbxBokSidor.TabIndex = 7;
            // 
            // tbxBokTitel
            // 
            this.tbxBokTitel.Location = new System.Drawing.Point(56, 35);
            this.tbxBokTitel.Name = "tbxBokTitel";
            this.tbxBokTitel.Size = new System.Drawing.Size(74, 20);
            this.tbxBokTitel.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLjud);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbxLjudSpelTid);
            this.groupBox2.Controls.Add(this.tbxLjudTitel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(156, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 110);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ljud";
            // 
            // btnLjud
            // 
            this.btnLjud.Location = new System.Drawing.Point(34, 78);
            this.btnLjud.Name = "btnLjud";
            this.btnLjud.Size = new System.Drawing.Size(75, 23);
            this.btnLjud.TabIndex = 8;
            this.btnLjud.Text = "Ljudspår";
            this.btnLjud.UseVisualStyleBackColor = true;
            this.btnLjud.Click += new System.EventHandler(this.btnLjud_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "label8";
            // 
            // tbxLjudSpelTid
            // 
            this.tbxLjudSpelTid.Location = new System.Drawing.Point(49, 52);
            this.tbxLjudSpelTid.Name = "tbxLjudSpelTid";
            this.tbxLjudSpelTid.Size = new System.Drawing.Size(83, 20);
            this.tbxLjudSpelTid.TabIndex = 5;
            // 
            // tbxLjudTitel
            // 
            this.tbxLjudTitel.Location = new System.Drawing.Point(47, 26);
            this.tbxLjudTitel.Name = "tbxLjudTitel";
            this.tbxLjudTitel.Size = new System.Drawing.Size(81, 20);
            this.tbxLjudTitel.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFilm);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.tbxFilmSpelTid);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbxFilmTitel);
            this.groupBox3.Location = new System.Drawing.Point(301, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 130);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Film";
            // 
            // btnFilm
            // 
            this.btnFilm.Location = new System.Drawing.Point(38, 93);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(75, 23);
            this.btnFilm.TabIndex = 7;
            this.btnFilm.Text = "Film";
            this.btnFilm.UseVisualStyleBackColor = true;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(65, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(73, 20);
            this.textBox3.TabIndex = 2;
            // 
            // tbxFilmSpelTid
            // 
            this.tbxFilmSpelTid.Location = new System.Drawing.Point(38, 45);
            this.tbxFilmSpelTid.Name = "tbxFilmSpelTid";
            this.tbxFilmSpelTid.Size = new System.Drawing.Size(100, 20);
            this.tbxFilmSpelTid.TabIndex = 1;
            // 
            // tbxFilmTitel
            // 
            this.tbxFilmTitel.Location = new System.Drawing.Point(38, 19);
            this.tbxFilmTitel.Name = "tbxFilmTitel";
            this.tbxFilmTitel.Size = new System.Drawing.Size(100, 20);
            this.tbxFilmTitel.TabIndex = 0;
            // 
            // lbxBibliotek
            // 
            this.lbxBibliotek.FormattingEnabled = true;
            this.lbxBibliotek.Location = new System.Drawing.Point(12, 148);
            this.lbxBibliotek.Name = "lbxBibliotek";
            this.lbxBibliotek.Size = new System.Drawing.Size(424, 95);
            this.lbxBibliotek.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 261);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbxBibliotek);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbxFilmSpelTid;
        private System.Windows.Forms.TextBox tbxFilmTitel;
        private System.Windows.Forms.Button btnBok;
        private System.Windows.Forms.TextBox tbxBokSidor;
        private System.Windows.Forms.TextBox tbxBokTitel;
        private System.Windows.Forms.Button btnLjud;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxLjudSpelTid;
        private System.Windows.Forms.TextBox tbxLjudTitel;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.ListBox lbxBibliotek;
        private System.Windows.Forms.Label label9;
    }
}

