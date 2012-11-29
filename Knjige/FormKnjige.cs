using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Knjige
{
    public partial class FormKnjige : Form
    {
        ArrayList listaKnjiga;

        public FormKnjige()
        {
            InitializeComponent();
            listaKnjiga = new ArrayList();
            MessageBox.Show("Fajl knjige.txt je uspešno zapamćen");
        }

        void napuniListu()
        {
            listBox1.Items.Clear();
            foreach (Knjiga k in listaKnjiga)
                listBox1.Items.Add(k);
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            FormNovaKnjiga fnk = new FormNovaKnjiga();
            if (DialogResult.OK == fnk.ShowDialog())
            {
                listaKnjiga.Add(new Knjiga(fnk.Naslov,fnk.Autor,fnk.Zanr, fnk.WebAdresa,fnk.DatumUnosa));
                napuniListu();

            }
        }

        private void btnEksport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
             foreach (Knjiga k in listaKnjiga)
                sw.WriteLine(k.ToString());
            sw.Close();
            MessageBox.Show("Fajl je snimljen pod nazivom " + saveFileDialog1.FileName);

        }

        void obrisiListu()
        {
            listBox1.Items.Clear();
            listaKnjiga.Clear();
        }

        private void btnSajt_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;
            FormSajt fs = new FormSajt();
            Knjiga k = (Knjiga)listBox1.SelectedItem;
            fs.Adresa = k.WebAdresa;
            fs.ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Da li ste sigurni", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                obrisiListu();
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
