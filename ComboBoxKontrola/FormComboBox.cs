using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxKontrola
{
    public partial class FormComboBox : Form
    {
        public FormComboBox()
        {
            InitializeComponent();
        }

        private void comboBoxIzbor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ovoj string promenjljivoj dodeljuje se vrednost
            //izabrane stavke u Combo Box-u
            string selektovano = comboBoxIzbor.SelectedItem.ToString();
            //izabrana stavka iz Combo Box-a upisuje se u text box
            textBox1.Text = "Odabrali ste: " + selektovano;
        }
    }
}
