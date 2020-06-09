using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
  
        }

        private void fontDialog2_Apply(object sender, EventArgs e)
        {

        }

        private void btnTeckenSnitt_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgFont.ShowDialog();
            if (r == DialogResult.OK)
            {
                rtxText.Font = dlgFont.Font;

            }
        }

        private void lblColor_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgColor.ShowDialog();
            if (r == DialogResult.OK)
            {
                lblColor.BackColor = dlgColor.Color;
                rtxText.SelectionBackColor = dlgColor.Color;
            }
        }

        private void rdnLeft_CheckedChanged(object sender, EventArgs e)
        {
            rtxText.Select();
            rtxText.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void rbnCenter_CheckedChanged(object sender, EventArgs e)
        {
            rtxText.Select();
            rtxText.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rbnRight_CheckedChanged(object sender, EventArgs e)
        {
            rtxText.Select();
            rtxText.SelectionAlignment = HorizontalAlignment.Right;
        }





        private void toolStripComboBox1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < FontFamily.Families.Length; i++)
            {
                cmbTeckenSnitt.Items.Add(FontFamily.Families[i].Name);
            }

            cmbTeckenSnitt.SelectedItem = "Arial";
        }

        private void nudkSize_ValueChanged(object sender, EventArgs e)
        {
            rtxText.Width = (int)nudkSize.Value;
            rtxText.Size = nudkSize.Size;
        }
        
    }
 }


