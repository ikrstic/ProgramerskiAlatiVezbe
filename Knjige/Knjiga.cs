using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Knjige
{
    public class Knjiga
    {
        string naslov;
        string autor;
        string zanr;
        string webAdresa;
        DateTime datumUnosa;

        public string Naslov { get { return this.naslov; } set { this.naslov = value; } }
        public string Autor { get { return this.autor; } set { this.autor = value; } }
        public string Zanr { get { return this.zanr; } set { this.zanr = value; } }
        public string WebAdresa { get { return this.webAdresa; } set { this.webAdresa = value; } }
        public DateTime DatumUnosa { get { return this.datumUnosa; } set { this.datumUnosa = value; } }

        public Knjiga()
        {
            this.naslov = "";
            this.autor = "";
            this.zanr = "";
            this.webAdresa = "";
            this.datumUnosa = DateTime.Now;
        }

        public Knjiga(string naslov, string autor, string zanr, string webAdresa, DateTime datumUnosa)
        {
            this.naslov = naslov;
            this.autor = autor;
            this.zanr = zanr;
            this.webAdresa = webAdresa;
            this.datumUnosa = datumUnosa;
        }

        public override string ToString()
        {
           return "Naslov: " + this.naslov + " / Autor: " + this.autor + " / " + this.webAdresa;
        }

    }
}
