using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobili
{
    public partial class Automobil : Form
    {
    
        private string model;
        private string proizvodjac;
        private string klasa;
        private string kubikaza;

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public string Proizvodjac
        {
            get
            {
                return proizvodjac;
            }
            set
            {
                proizvodjac = value;
            }
        }
        public string Klasa
        {
            get
            {
                return klasa;
            }
            set
            {
                klasa = value;
            }
        }
        public string Kubikaza
        {
            get
            {
                return kubikaza;
            }
            set
            {
                kubikaza = value;
            }
        }
        public override string ToString()
        {
            return "Model: " + model + "/ Proizvođač: " + proizvodjac + "/ Kubikaža: " + kubikaza;
        }
        //public Automobil(string m, string p, string k, string cc)
        //{
        //    model = m;
        //    proizvodjac = p;
        //    klasa = k;
        //    kubikaza = cc;
        //}
        ////metod NoviAutomobil
        //public string NoviAutomovil()
        //{
        //    return model;
        //    return proizvodjac;
        //    return klasa;
        //    return kubikaza;
        //}
    }
}
