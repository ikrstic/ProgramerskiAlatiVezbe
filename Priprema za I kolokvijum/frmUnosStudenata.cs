using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Priprema_za_I_kolokvijum
{
    public partial class frmUnosStudenata : Form
    {
        public string Ime { get { return this.tbIme.Text; } }

        public int GodRodjenja
        { get { return Convert.ToInt32(this.tbGodRodjenja.Text); } }

        public string Pol
        { get { return vratiPol(); } }

        public string Smer
        { get { return this.cbSmer.Text; } }

        public frmUnosStudenata()
        {
            InitializeComponent();
        }

        private string vratiPol()
        {
            string pol = "";
            if (rbMuski.Checked == true)
            {
                pol = "Muski";
            }
            else
            {
                pol = "Zenski";
            }

            return pol; 
        }

        // resetovanje kontrola
        private void resetuj()
        {
            tbIme.Clear();
            tbGodRodjenja.Clear();
            cbSmer.Text ="";
        }

        // onemogucavanje unosa svega sem brojeva u TextBox kontrolu za godinu rodjenja
        private void tbGodRodjenja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        // validacija TextBox-a za ime
        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if (tbIme.Text == "")
            {
                errGreska.SetError(tbIme, "Morate uneti ime i prezime");
                tbIme.Focus();
            }
            else
            {
                errGreska.Clear();
            }
        }

        // validacija TextBox-a za godinu rodjenja
        private void tbGodRodjenja_Validating(object sender, CancelEventArgs e)
        {
            if (tbGodRodjenja.Text == "")
            {
                errGreska.SetError(tbGodRodjenja, "Morate uneti godinu rodjenja");
                tbGodRodjenja.Focus();
            }
            else
            {
                errGreska.Clear();
            }
        }     

        // validacija ComboBox-a smer
        private void cbSmer_Validating(object sender, CancelEventArgs e)
        {
            if (cbSmer.Text == "")
            {
                errGreska.SetError(cbSmer, "Morate izabrati smer");
                cbSmer.Focus();
            }
            else
            {
                errGreska.Clear();
            }
        }

        // onemogucivanje unosa teksta u ComboBox kontrolu
        private void cbSmer_KeyPress(object sender, KeyPressEventArgs e)
        {
            errGreska.SetError(cbSmer, "Morate izabrati smer");
            e.Handled = true;    
        }

        // vracanje odogovarajuceg DialoGResult-a
        private void btnPrihvati_Click(object sender, EventArgs e)
        {
            if (tbIme.Text != "" && tbGodRodjenja.Text != "" && cbSmer.Text != "")
            {   
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Niste uneli sve podatke", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // resetovanje kontrola
        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            resetuj();
        }

        // zatvaranje forme
        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
