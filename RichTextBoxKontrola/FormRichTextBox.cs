using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBoxKontrola
{
    public partial class FormRichTextBox : Form
    {
        public FormRichTextBox()
        {
            InitializeComponent();
        }

        private void buttonSacuvaj_Click_Click(object sender, EventArgs e)
        {
            //Poziv metode SaveFile() za čuvanje sadržaja richTextBox-a
            //u fajlu uz navođenje tačno odrežene putanje
            richTextBox1.SaveFile(@"C:Tempproba.rtf");
        }

        private void buttonCitaj_Click_Click(object sender, EventArgs e)
        {
            //poziv metode LoadFile() za učitavanje tekstualnog fajla
            // u richTextBox
            richTextBox1.LoadFile(@"C:Tempproba.rtf");
        }

        private void buttonBrisi_Click_Click(object sender, EventArgs e)
        {
            //POziv metode clear koja priše sadržaj richTextBox-a
            richTextBox1.Clear();
        }
    }
}
