using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vezba16PripremaPrvogKolokvijuma
{
    public partial class frmSkola : Form
    {
        public frmSkola()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUnosStudenta frm = new frmUnosStudenta();
            DialogResult rez = frm.ShowDialog();
            //unos novog studenta u list box
            if (rez == System.Windows.Forms.DialogResult.OK)
                listBoxStudenti.Items.Add(frm.Student1.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(listBoxStudenti.SelectedIndex < 0))
                listBoxStudenti.Items.RemoveAt(listBoxStudenti.SelectedIndex);

            MessageBox.Show("Prvi student je izbačen!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBoxStudenti.Items.Clear();
        }

        private void buttonExport2txt_Click(object sender, EventArgs e)
        {
            //string filePath = @"Studenti.txt";
            //string fileContent = Convert.ToString(listBoxStudenti.Items);
            //File.WriteAllText(filePath, fileContent);

            //string t = listBoxStudenti.ToString();
            ////Unos u dokument
            //StreamWriter sr = File.CreateText(@"Studenti.txt");
            //sr.Write(t);
            //sr.Close();
            StreamWriter sw = new StreamWriter(@"Studenti.txt");

                foreach (object item in listBoxStudenti.Items)

                    sw.WriteLine(item.ToString());

                sw.Close();     
            MessageBox.Show("Tekst je sačuvan.");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
