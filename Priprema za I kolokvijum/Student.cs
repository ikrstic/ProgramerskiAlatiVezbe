using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Priprema_za_I_kolokvijum
{
    class Student
    {
        private string ime;
        private int godRodjenja;
        private string pol;
        private string smer;

        public string Ime
        {
            get { return this.ime; }
            set { this.ime = value; }
        }

        public int GodRodjenja
        {
            get { return this.godRodjenja; }
            set { this.godRodjenja = value; }
        }

        public string Pol
        {
            get { return this.pol; }
            set { this.pol = value; }
        }

        public string Smer
        {
            get { return this.smer; }
            set { this.smer = value; }
        }

        public Student()
        {
            this.ime = "";
            this.pol = "";
            this.smer = "";
            this.godRodjenja = 0;
        }

        public Student(string s, string i, string p, int gr)
        {
            this.smer = s;
            this.ime = i;
            this.pol = p;
            this.godRodjenja = gr;
        }

        public override string ToString()
        {
            return "Ime i prezime: " + this.ime + " | Pol: " + this.pol + " | Godina rodjenja: " + godRodjenja.ToString() + " | Smer: " + this.smer;
        }
    }
}
