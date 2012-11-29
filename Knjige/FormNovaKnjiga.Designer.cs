namespace Knjige
{
    partial class FormNovaKnjiga
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNaslov = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.cbZanr = new System.Windows.Forms.ComboBox();
            this.btnPrihvati = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNoviZanr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDodajZanr = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbWebAdresa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naslov:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Žanr:";
            // 
            // tbNaslov
            // 
            this.tbNaslov.Location = new System.Drawing.Point(88, 13);
            this.tbNaslov.Name = "tbNaslov";
            this.tbNaslov.Size = new System.Drawing.Size(192, 20);
            this.tbNaslov.TabIndex = 1;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(88, 40);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(192, 20);
            this.tbAutor.TabIndex = 2;
            // 
            // cbZanr
            // 
            this.cbZanr.FormattingEnabled = true;
            this.cbZanr.Items.AddRange(new object[] {
            "SF",
            "Drama",
            "Komedija"});
            this.cbZanr.Location = new System.Drawing.Point(88, 93);
            this.cbZanr.Name = "cbZanr";
            this.cbZanr.Size = new System.Drawing.Size(192, 21);
            this.cbZanr.TabIndex = 4;
            // 
            // btnPrihvati
            // 
            this.btnPrihvati.Location = new System.Drawing.Point(12, 181);
            this.btnPrihvati.Name = "btnPrihvati";
            this.btnPrihvati.Size = new System.Drawing.Size(128, 23);
            this.btnPrihvati.TabIndex = 8;
            this.btnPrihvati.Text = "Prihvati";
            this.btnPrihvati.UseVisualStyleBackColor = true;
            this.btnPrihvati.Click += new System.EventHandler(this.btnPrihvati_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOtkazi.Location = new System.Drawing.Point(153, 181);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(127, 23);
            this.btnOtkazi.TabIndex = 9;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Datum unosa:";
            // 
            // tbNoviZanr
            // 
            this.tbNoviZanr.Location = new System.Drawing.Point(88, 120);
            this.tbNoviZanr.Name = "tbNoviZanr";
            this.tbNoviZanr.Size = new System.Drawing.Size(140, 20);
            this.tbNoviZanr.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dodati žanr:";
            // 
            // btnDodajZanr
            // 
            this.btnDodajZanr.Location = new System.Drawing.Point(234, 120);
            this.btnDodajZanr.Name = "btnDodajZanr";
            this.btnDodajZanr.Size = new System.Drawing.Size(46, 20);
            this.btnDodajZanr.TabIndex = 6;
            this.btnDodajZanr.Text = "Dodaj";
            this.btnDodajZanr.UseVisualStyleBackColor = true;
            this.btnDodajZanr.Click += new System.EventHandler(this.btnDodajZanr_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Web adresa:";
            // 
            // tbWebAdresa
            // 
            this.tbWebAdresa.Location = new System.Drawing.Point(88, 66);
            this.tbWebAdresa.Name = "tbWebAdresa";
            this.tbWebAdresa.Size = new System.Drawing.Size(192, 20);
            this.tbWebAdresa.TabIndex = 3;
            // 
            // FormNovaKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 215);
            this.Controls.Add(this.btnDodajZanr);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnPrihvati);
            this.Controls.Add(this.cbZanr);
            this.Controls.Add(this.tbWebAdresa);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.tbNoviZanr);
            this.Controls.Add(this.tbNaslov);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNovaKnjiga";
            this.Text = "FormNovaKnjiga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNaslov;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.ComboBox cbZanr;
        private System.Windows.Forms.Button btnPrihvati;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNoviZanr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDodajZanr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbWebAdresa;
    }
}