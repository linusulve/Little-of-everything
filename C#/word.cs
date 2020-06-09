using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        Label sample;
        
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < FontFamily.Families.Length; i++)
            {
                cbxTeckenSnitt.Items.Add(FontFamily.Families[i].Name);
            }
            cbxTeckenSnitt.SelectedItem = "Arial";

           
         

        }

   
        private void btnTeckenSnitt_Click(object sender, EventArgs e)
        {
                DialogResult r = dlgFont.ShowDialog();
                if (r == DialogResult.OK)
                {
                    rtfDokument.Select();
                    rtfDokument.SelectionFont = dlgFont.Font;
                }
            }

        private void rbnLeft_CheckedChanged(object sender, EventArgs e)
        {
            rtfDokument.Select();
            rtfDokument.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void rbnCenter_CheckedChanged(object sender, EventArgs e)
        {
            rtfDokument.Select();
            rtfDokument.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void rdnRight_CheckedChanged(object sender, EventArgs e)
        {
            rtfDokument.Select();
            rtfDokument.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgColor.ShowDialog();
            if (r == DialogResult.OK)
            {
                rtfDokument.SelectionColor = dlgColor.Color;
                btnColor.BackColor = rtfDokument.SelectionColor;
                
            }
        }

        private void rtfDokument_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            rtfDokument.Select();
            rtfDokument.SelectionColor = Color.Yellow;
        }

       

        private void cbxTeckenSnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtfDokument.Text += cbxTeckenSnitt.SelectedItem.ToString();
        }

        private void btnRöd_Click(object sender, EventArgs e)
        {
            rtfDokument.Select();
            rtfDokument.SelectionColor = Color.Red;
        }

        private void btnGrön_Click(object sender, EventArgs e)
        {
            rtfDokument.Select();
            rtfDokument.SelectionColor = Color.Green;
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            rtfDokument.Select();
            rtfDokument.SelectionColor = Color.Purple;
            btnColor.BackColor = Color.Purple;           
        }

        private void rbnF_CheckedChanged(object sender, EventArgs e)
        {
            rtfDokument.SelectionFont = new Font("Tahoma", 12, FontStyle.Bold);
        }

        private void nudFont_ValueChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        
             string[] words = tbxSearch.Text.Split(',');
                foreach (string word in words)
                {
                    int startindex = 0;
                    while (startindex < rtfDokument.TextLength)
                    {
                        int wordstartIndex = rtfDokument.Find(word, startindex, RichTextBoxFinds.None);
                        if (wordstartIndex != -1)
                        {
                            rtfDokument.SelectionStart = wordstartIndex;
                            rtfDokument.SelectionLength = word.Length;
                            rtfDokument.SelectionBackColor = Color.Yellow;
                        }
                        else
                            break;
                        startindex += wordstartIndex + word.Length;
                    }
                }
            

           
        
    }

        private void rbnK_CheckedChanged(object sender, EventArgs e)
        {
            rtfDokument.SelectionFont = new Font("Tahoma", 12, FontStyle.Italic);        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgColor.ShowDialog();
            if (r == DialogResult.OK) ;
            {
                rtfDokument.BackColor = dlgColor.Color;
                btnBack.BackColor = rtfDokument.BackColor;
                btnBack.BackColor = btnBack.BackColor;
            }
        }
    }
 }
