namespace Automobili
{
    partial class FormAutomobili
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxAutomobili = new System.Windows.Forms.ListBox();
            this.buttonNovi = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.buttonZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAutomobili
            // 
            this.listBoxAutomobili.FormattingEnabled = true;
            this.listBoxAutomobili.Location = new System.Drawing.Point(12, 12);
            this.listBoxAutomobili.Name = "listBoxAutomobili";
            this.listBoxAutomobili.Size = new System.Drawing.Size(470, 407);
            this.listBoxAutomobili.TabIndex = 0;
            // 
            // buttonNovi
            // 
            this.buttonNovi.Location = new System.Drawing.Point(12, 437);
            this.buttonNovi.Name = "buttonNovi";
            this.buttonNovi.Size = new System.Drawing.Size(115, 23);
            this.buttonNovi.TabIndex = 1;
            this.buttonNovi.Text = "Novi Automobil";
            this.buttonNovi.UseVisualStyleBackColor = true;
            this.buttonNovi.Click += new System.EventHandler(this.buttonNovi_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(171, 437);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(85, 23);
            this.buttonExport.TabIndex = 2;
            this.buttonExport.Text = "Export to txt";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(293, 437);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(75, 23);
            this.buttonObrisi.TabIndex = 3;
            this.buttonObrisi.Text = "Obriši";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.Location = new System.Drawing.Point(407, 437);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(75, 23);
            this.buttonZatvori.TabIndex = 4;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click);
            // 
            // FormAutomobili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 472);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonNovi);
            this.Controls.Add(this.listBoxAutomobili);
            this.Name = "FormAutomobili";
            this.Text = "Automobili";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAutomobili;
        private System.Windows.Forms.Button buttonNovi;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonZatvori;
    }
}

