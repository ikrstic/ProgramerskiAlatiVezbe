using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObradaIzuzetaka
{
    public partial class FormObradaIzuzetaka : Form
    {
        public FormObradaIzuzetaka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //upotreba try - catch blokova u cilju obezbeđivanja
            //povratne ingormacije u slučaju greške, kao i omogućavanja
            //da zbog pojave geške u unosu podataka od strane korisnika 
            //aplikacija "pukne" u sred njenog izvršanja
            try
            {
                double broj1 = Convert.ToDouble(textBoxPrviBroj.Text);
                double broj2 = Convert.ToDouble(textBoxDrugiBroj.Text);
                double zbir = broj1 + broj2;
                MessageBox.Show("Zbir je: " + zbir);
            }
            //ispisivanje poruke u slučaju neispravnog 
            //tipa podataka u text box
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //brisanje sadržaja text box-a
            textBoxPrviBroj.Clear();
            textBoxDrugiBroj.Clear();
        }
    }
}
