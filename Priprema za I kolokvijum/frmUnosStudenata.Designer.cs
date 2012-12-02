namespace Priprema_za_I_kolokvijum
{
    partial class frmUnosStudenata
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbPol = new System.Windows.Forms.GroupBox();
            this.rbZenski = new System.Windows.Forms.RadioButton();
            this.rbMuski = new System.Windows.Forms.RadioButton();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbGodRodjenja = new System.Windows.Forms.TextBox();
            this.btnPrihvati = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.errGreska = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cbSmer = new System.Windows.Forms.ComboBox();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.gbPol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errGreska)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime i prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Godina rodjenja:";
            // 
            // gbPol
            // 
            this.gbPol.Controls.Add(this.rbZenski);
            this.gbPol.Controls.Add(this.rbMuski);
            this.gbPol.Location = new System.Drawing.Point(16, 115);
            this.gbPol.Name = "gbPol";
            this.gbPol.Size = new System.Drawing.Size(165, 54);
            this.gbPol.TabIndex = 3;
            this.gbPol.TabStop = false;
            this.gbPol.Text = "Pol";
            // 
            // rbZenski
            // 
            this.rbZenski.AutoSize = true;
            this.rbZenski.Location = new System.Drawing.Point(99, 20);
            this.rbZenski.Name = "rbZenski";
            this.rbZenski.Size = new System.Drawing.Size(57, 17);
            this.rbZenski.TabIndex = 1;
            this.rbZenski.TabStop = true;
            this.rbZenski.Text = "Zenski";
            this.rbZenski.UseVisualStyleBackColor = true;
            // 
            // rbMuski
            // 
            this.rbMuski.AutoSize = true;
            this.rbMuski.Location = new System.Drawing.Point(16, 20);
            this.rbMuski.Name = "rbMuski";
            this.rbMuski.Size = new System.Drawing.Size(53, 17);
            this.rbMuski.TabIndex = 0;
            this.rbMuski.TabStop = true;
            this.rbMuski.Text = "Muski";
            this.rbMuski.UseVisualStyleBackColor = true;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(115, 47);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(150, 20);
            this.tbIme.TabIndex = 4;
            this.tbIme.Validating += new System.ComponentModel.CancelEventHandler(this.tbIme_Validating);
            // 
            // tbGodRodjenja
            // 
            this.tbGodRodjenja.Location = new System.Drawing.Point(115, 80);
            this.tbGodRodjenja.Name = "tbGodRodjenja";
            this.tbGodRodjenja.Size = new System.Drawing.Size(85, 20);
            this.tbGodRodjenja.TabIndex = 6;
            this.tbGodRodjenja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGodRodjenja_KeyPress);
            this.tbGodRodjenja.Validating += new System.ComponentModel.CancelEventHandler(this.tbGodRodjenja_Validating);
            // 
            // btnPrihvati
            // 
            this.btnPrihvati.Location = new System.Drawing.Point(17, 201);
            this.btnPrihvati.Name = "btnPrihvati";
            this.btnPrihvati.Size = new System.Drawing.Size(75, 23);
            this.btnPrihvati.TabIndex = 7;
            this.btnPrihvati.Text = "Prihvati";
            this.btnPrihvati.UseVisualStyleBackColor = true;
            this.btnPrihvati.Click += new System.EventHandler(this.btnPrihvati_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(115, 201);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 8;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // errGreska
            // 
            this.errGreska.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Smer:";
            // 
            // cbSmer
            // 
            this.cbSmer.FormattingEnabled = true;
            this.cbSmer.Items.AddRange(new object[] {
            "Informacione tehnologije",
            "Elektronsko poslovanje",
            "Racunarska multimedija",
            "Organizacija poslovnih sistema"});
            this.cbSmer.Location = new System.Drawing.Point(115, 15);
            this.cbSmer.Name = "cbSmer";
            this.cbSmer.Size = new System.Drawing.Size(150, 21);
            this.cbSmer.TabIndex = 10;
            this.cbSmer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbSmer_KeyPress);
            this.cbSmer.Validating += new System.ComponentModel.CancelEventHandler(this.cbSmer_Validating);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(206, 201);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 11;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // frmUnosStudenata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 245);
            this.ControlBox = false;
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.cbSmer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnPrihvati);
            this.Controls.Add(this.tbGodRodjenja);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.gbPol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmUnosStudenata";
            this.Text = "Novi student";
            this.gbPol.ResumeLayout(false);
            this.gbPol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errGreska)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbPol;
        private System.Windows.Forms.RadioButton rbZenski;
        private System.Windows.Forms.RadioButton rbMuski;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbGodRodjenja;
        private System.Windows.Forms.Button btnPrihvati;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.ErrorProvider errGreska;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSmer;
        private System.Windows.Forms.Button btnZatvori;
    }
}

