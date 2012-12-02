using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobili
{
    public partial class NoviAutomobil : Form
    {
        public Automobil noviautomobil1;
        public NoviAutomobil()
        {
            InitializeComponent();
        }
        public Automobil Automobil1
        {
            get
            {
                return noviautomobil1;
            }
            set
            {
                noviautomobil1 = value;
            }
        }

        private void buttonSnimi_Click(object sender, EventArgs e)
        {
            // Kubikaze.
            DomainUpDown.DomainUpDownItemCollection items = this.domainUpDownKubikaza.Items;
            items.Add("900");
            items.Add("1000");
            items.Add("1100");
            items.Add("1200");
            items.Add("1300");
            items.Add("1500");
            items.Add("1800");
            items.Add("2000");
            items.Add("3000");
            items.Add("4000");
            items.Add("5000");
            items.Add("6000");
            //kreiranje novog objekta tipa Automobil
            noviautomobil1 = new Automobil();
            //pristup odgovarajućim atributima klase Automobil
            noviautomobil1.Model = textBoxModel.Text;
            noviautomobil1.Proizvodjac = textBoxProizvodjac.Text;
            noviautomobil1.Klasa = comboBoxKlasa.Text;
            noviautomobil1.Kubikaza = domainUpDownKubikaza.Text;
            DialogResult = DialogResult.OK;
        }

        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
