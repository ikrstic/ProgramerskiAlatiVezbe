using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Priprema_za_I_kolokvijum
{
    public partial class frmSkola : Form
    {        
        private Queue<Student> studenti;
        private Student s;
        
        public frmSkola()
        {
            InitializeComponent();
            studenti = new Queue<Student>();
        }

        // prikaz svih studenta u ListBox kontroli
        private void prikaziSpisak()
        {
            foreach (Student s in studenti)
            {
                lbSpisak.Items.Add(s.ToString());
            }
        }

        // otvaranje frmUnosStudenata i sakupljanje podataka 
        // upis podataka u studenta
        // upis studenta u red
        // poziv metode za prikaz studenata iz reda
        private void btnUnos_Click(object sender, EventArgs e)
        {             
                frmUnosStudenata frm = new frmUnosStudenata();

                if (DialogResult.OK == frm.ShowDialog())
                {
                    s = new Student(frm.Smer, frm.Ime, frm.Pol, frm.GodRodjenja);   
                    studenti.Enqueue(s);
                    lbSpisak.Items.Clear();
                    prikaziSpisak();
                }
         }

        // izbacivanje prvog studenta u redu
        // poziv metode za prikaz studenata iz reda
        private void btnIzbaci_Click(object sender, EventArgs e)
        {
            if (studenti.Count != 0)
            {
                studenti.Dequeue();
                lbSpisak.Items.Clear();
                MessageBox.Show("Prvi student je izbacen", "Obavestenje");
                prikaziSpisak();
            }
            else
            {
                MessageBox.Show("U redu nema studenata", "Obavestenje");
            }
        }

        // izbacivanje svih studenata iz reda
        private void btnIzbaciSve_Click(object sender, EventArgs e)
        {
            studenti.Clear();
            lbSpisak.Items.Clear();
            MessageBox.Show("Svi studenti su izbaceni", "Obavestenje");
        }

        // upis reda studenata u txt fajl
        private void btnExport_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("studenti.txt");
            foreach (Student s in studenti)
                sw.WriteLine(s.ToString());
            sw.Close();
            MessageBox.Show("Fajl studenti.txt je uspešno snimljen", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // zatvaranje forme
        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
