using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxKontrola
{
    public partial class FormTextBoxKontrola : Form
    {
        public FormTextBoxKontrola()
        {
            InitializeComponent();
        }

        private void FormTextBoxKontrola_Load(object sender, EventArgs e)
        {
            textBoxIme.Text = "Unesite Ime";
            textBoxPrezime.Text = "Unesite Prezime";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ime = textBoxIme.Text;
            string prezime = textBoxPrezime.Text;
            MessageBox.Show(ime + " " + prezime);
            textBoxIme.Text = "Unesite Ime";
            textBoxPrezime.Text = "Unesite Prezime";
            //textBoxIme.Clear();
            //textBoxPrezime.Clear();
        }
    }
}
