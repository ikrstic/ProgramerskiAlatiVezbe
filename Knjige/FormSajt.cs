using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Knjige
{
    public partial class FormSajt : Form
    {
        public string Adresa { set { Uri u = new Uri(value); this.webBrowser1.Url = u; } }

        public FormSajt()
        {
            InitializeComponent();
        }
    }
}
