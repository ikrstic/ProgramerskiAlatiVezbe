using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO; // zbog upotrebe klase ArrayList

namespace Automobili
{
    public partial class FormAutomobili : Form
    {
        //Deklaracija i instanciranje globalne promenjive liste automobila
        ArrayList listaAutomobila = new ArrayList();
        //Konstruktor forme
        public FormAutomobili()
        {
            InitializeComponent();
        }

        private void buttonNovi_Click(object sender, EventArgs e)
        {
            NoviAutomobil na = new NoviAutomobil();
            DialogResult rez = na.ShowDialog();
            //unos novog automobila u listbox
            if (rez == System.Windows.Forms.DialogResult.OK)
                listBoxAutomobili.Items.Add(na.Automobil1.ToString());
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"Automobili.txt");

            foreach (object item in listBoxAutomobili.Items)

                sw.WriteLine(item.ToString());

            sw.Close();
            MessageBox.Show("Tekst je sačuvan kao Automobili.txt.");
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            listBoxAutomobili.Items.Clear();

            MessageBox.Show("Obrisana je lista automobila!");
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
