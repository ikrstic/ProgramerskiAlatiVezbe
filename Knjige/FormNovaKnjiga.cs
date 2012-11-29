using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Knjige
{
    public partial class FormNovaKnjiga : Form
    {
        public string Naslov { get { return this.tbNaslov.Text; } }
        public string Autor { get { return this.tbAutor.Text; } }
        public string Zanr { get { return this.cbZanr.SelectedItem.ToString(); } }
        public string WebAdresa { get { return this.tbWebAdresa.Text; } }
        public DateTime DatumUnosa { get { return this.dateTimePicker1.Value; } }

        public FormNovaKnjiga()
        {
            InitializeComponent();
        }

        private void btnDodajZanr_Click(object sender, EventArgs e)
        {
            if(tbNoviZanr.Text!="")
            cbZanr.Items.Add(tbNoviZanr.Text);
        }

        private void btnPrihvati_Click(object sender, EventArgs e)
        {
            if (tbAutor.Text != "" && tbNaslov.Text != "" && tbWebAdresa.Text !="" && cbZanr.SelectedItem != null)
                DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Molimo ispunite sva polja");

        }
    }
}
