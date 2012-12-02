namespace Priprema_za_I_kolokvijum
{
    partial class frmSkola
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
            this.btnUnos = new System.Windows.Forms.Button();
            this.lbSpisak = new System.Windows.Forms.ListBox();
            this.btnIzbaci = new System.Windows.Forms.Button();
            this.btnIzbaciSve = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(16, 227);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(107, 23);
            this.btnUnos.TabIndex = 2;
            this.btnUnos.Text = "Unos studenta";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // lbSpisak
            // 
            this.lbSpisak.FormattingEnabled = true;
            this.lbSpisak.Location = new System.Drawing.Point(16, 18);
            this.lbSpisak.Name = "lbSpisak";
            this.lbSpisak.Size = new System.Drawing.Size(529, 199);
            this.lbSpisak.TabIndex = 3;
            // 
            // btnIzbaci
            // 
            this.btnIzbaci.Location = new System.Drawing.Point(149, 227);
            this.btnIzbaci.Name = "btnIzbaci";
            this.btnIzbaci.Size = new System.Drawing.Size(90, 23);
            this.btnIzbaci.TabIndex = 4;
            this.btnIzbaci.Text = "Izbaci studenta";
            this.btnIzbaci.UseVisualStyleBackColor = true;
            this.btnIzbaci.Click += new System.EventHandler(this.btnIzbaci_Click);
            // 
            // btnIzbaciSve
            // 
            this.btnIzbaciSve.Location = new System.Drawing.Point(262, 227);
            this.btnIzbaciSve.Name = "btnIzbaciSve";
            this.btnIzbaciSve.Size = new System.Drawing.Size(75, 23);
            this.btnIzbaciSve.TabIndex = 5;
            this.btnIzbaciSve.Text = "Izbaci sve";
            this.btnIzbaciSve.UseVisualStyleBackColor = true;
            this.btnIzbaciSve.Click += new System.EventHandler(this.btnIzbaciSve_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(364, 227);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export u txt";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(470, 227);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 7;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // frmSkola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 262);
            this.ControlBox = false;
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnIzbaciSve);
            this.Controls.Add(this.btnIzbaci);
            this.Controls.Add(this.lbSpisak);
            this.Controls.Add(this.btnUnos);
            this.Name = "frmSkola";
            this.Text = "Skola";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.ListBox lbSpisak;
        private System.Windows.Forms.Button btnIzbaci;
        private System.Windows.Forms.Button btnIzbaciSve;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnZatvori;
    }
}