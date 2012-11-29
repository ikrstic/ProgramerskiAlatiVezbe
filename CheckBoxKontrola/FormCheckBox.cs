using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxKontrola
{
    public partial class FormCheckBox : Form
    {
        public FormCheckBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //poziv metode Clear() za brisanje sadržaja text box-a
            textBox1.Clear();
            //poziv metode AppendText() za dodavanje sadržaja u text box
            textBox1.AppendText("Odabrali ste: " + Environment.NewLine);
            if (checkBoxDorucak.Checked)
                textBox1.AppendText("doručak" + Environment.NewLine);
            if (checkBoxRucak.Checked)
                textBox1.AppendText("ručak" + Environment.NewLine);
            if (checkBoxVecera.Checked)
                textBox1.AppendText("večera" + Environment.NewLine);
        }

        private void checkBoxSakri_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Visible == false)
                textBox1.Visible = true;
            else
                textBox1.Visible = false;
        }
    }
}
