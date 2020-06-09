using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        List<Media> mediaLista = new List<Media>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBok_Click(object sender, EventArgs e)
        {
            Bok nyBok = new Bok();
            nyBok.Titel = tbxBokTitel.Text;
            nyBok.AntalSidor = int.Parse(tbxBokSidor.Text);
            mediaLista.Add(nyBok);
            lbxBibliotek.Items.Add(nyBok);
        }

        private void btnLjud_Click(object sender, EventArgs e)
        {
            Ljudspår nyttLjud = new Ljudspår();
            nyttLjud.Titel = tbxLjudTitel.Text;
            nyttLjud.SpelTid = double.Parse(tbxLjudSpelTid.Text);

            mediaLista.Add(nyttLjud);
            lbxBibliotek.Items.Add(nyttLjud);
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            Film nyFilm = new Film();
            nyFilm.Titel = tbxFilmTitel.Text;
            nyFilm.SpelTid = double.Parse(tbxFilmSpelTid.Text);

            mediaLista.Add(nyFilm);
            lbxBibliotek.Items.Add(nyFilm);
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }


public class Media
    {
        public string Titel = "";

        public override string ToString()
        {
            return Titel;
        }
    }


    public class Bok : Media
    {
        public int AntalSidor = 0;

        public override string ToString()
        {
            return Titel + ": " + AntalSidor + " sidor";
        }
    }

    public class Ljudspår : Media
    {
        public double SpelTid = 0;

        public override string ToString()
        {
            return Titel + ": " + SpelTid + " minuter";
        }
    }
    
    public class Film : Media
    {
        public double SpelTid = 0;

        public override string ToString()
        {
            return Titel + ": " + SpelTid + " ,omiter";
        }
    }
}

