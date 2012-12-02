using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba16PripremaPrvogKolokvijuma
{
    public class Student
    {
        private string ime;
        private string smer;
        private string pol;
        private int godRodjenja;

        public Student()
        {
            
        }
        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                ime = value;
            }
        }
        public string Smer
        {
            get
            {
                return smer;
            }
            set
            {
                smer = value;
            }
        }
        public string Pol
        {
            get
            {
                return pol;
            }
            set
            {
                pol = value;
            }
        }
        public int GodRodjenja
        {
            get
            {
                return godRodjenja;
            }
            set
            {
                godRodjenja = value;
            }
        }
        public override string ToString()
        {
            return "Ime i prezime: " + ime + " | Pol: " + pol + " | Godina rođenja: " + godRodjenja + " | Smer: " + smer;
        }
    }
}
