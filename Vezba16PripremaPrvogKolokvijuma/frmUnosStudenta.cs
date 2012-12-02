using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vezba16PripremaPrvogKolokvijuma
{
    public partial class frmUnosStudenta : Form
    {
        public Student student1;
        public frmUnosStudenta()
        {
            InitializeComponent();
        }
        public Student Student1
        {
            get
            {
                return student1;   
            }
            set
            {
                student1 = value;
            }
        }

        private void butonSnimi_Click_Click(object sender, EventArgs e)
        {
            //kreiranje novog objekta tipa Student
            student1 = new Student();
            //pristup odgovarajućim atributima klase student
            student1.Ime = textBoxIme.Text;
            student1.Smer = comboBoxSmer.SelectedItem.ToString();
            student1.GodRodjenja = Convert.ToInt32(textBoxGod.Text);
            student1.Pol = "";
                if (radioButtonMuski.Checked)
                    {
                        student1.Pol = radioButtonMuski.Text;
                    }
                else if (radioButtonZenski.Checked)
                    {
                        student1.Pol = radioButtonZenski.Text;
                    }
             DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }
    }
}
