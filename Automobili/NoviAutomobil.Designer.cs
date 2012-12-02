namespace Automobili
{
    partial class NoviAutomobil
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
            this.labelModel = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelProizvodjac = new System.Windows.Forms.Label();
            this.textBoxProizvodjac = new System.Windows.Forms.TextBox();
            this.labelKlasa = new System.Windows.Forms.Label();
            this.comboBoxKlasa = new System.Windows.Forms.ComboBox();
            this.labelKubikaza = new System.Windows.Forms.Label();
            this.domainUpDownKubikaza = new System.Windows.Forms.DomainUpDown();
            this.buttonSnimi = new System.Windows.Forms.Button();
            this.buttonOtkazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(12, 20);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(36, 13);
            this.labelModel.TabIndex = 0;
            this.labelModel.Text = "Model";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(90, 13);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(182, 20);
            this.textBoxModel.TabIndex = 1;
            // 
            // labelProizvodjac
            // 
            this.labelProizvodjac.AutoSize = true;
            this.labelProizvodjac.Location = new System.Drawing.Point(12, 65);
            this.labelProizvodjac.Name = "labelProizvodjac";
            this.labelProizvodjac.Size = new System.Drawing.Size(61, 13);
            this.labelProizvodjac.TabIndex = 2;
            this.labelProizvodjac.Text = "Proizvođač";
            // 
            // textBoxProizvodjac
            // 
            this.textBoxProizvodjac.Location = new System.Drawing.Point(90, 58);
            this.textBoxProizvodjac.Name = "textBoxProizvodjac";
            this.textBoxProizvodjac.Size = new System.Drawing.Size(182, 20);
            this.textBoxProizvodjac.TabIndex = 3;
            // 
            // labelKlasa
            // 
            this.labelKlasa.AutoSize = true;
            this.labelKlasa.Location = new System.Drawing.Point(12, 111);
            this.labelKlasa.Name = "labelKlasa";
            this.labelKlasa.Size = new System.Drawing.Size(33, 13);
            this.labelKlasa.TabIndex = 4;
            this.labelKlasa.Text = "Klasa";
            // 
            // comboBoxKlasa
            // 
            this.comboBoxKlasa.FormattingEnabled = true;
            this.comboBoxKlasa.Items.AddRange(new object[] {
            "Gradski",
            "Sporstki",
            "Terenac",
            "SUV",
            "Kombi",
            "Karavan"});
            this.comboBoxKlasa.Location = new System.Drawing.Point(90, 103);
            this.comboBoxKlasa.Name = "comboBoxKlasa";
            this.comboBoxKlasa.Size = new System.Drawing.Size(182, 21);
            this.comboBoxKlasa.TabIndex = 5;
            // 
            // labelKubikaza
            // 
            this.labelKubikaza.AutoSize = true;
            this.labelKubikaza.Location = new System.Drawing.Point(12, 157);
            this.labelKubikaza.Name = "labelKubikaza";
            this.labelKubikaza.Size = new System.Drawing.Size(55, 13);
            this.labelKubikaza.TabIndex = 6;
            this.labelKubikaza.Text = "Kubukaža";
            // 
            // domainUpDownKubikaza
            // 
            this.domainUpDownKubikaza.Location = new System.Drawing.Point(90, 150);
            this.domainUpDownKubikaza.Name = "domainUpDownKubikaza";
            this.domainUpDownKubikaza.Size = new System.Drawing.Size(182, 20);
            this.domainUpDownKubikaza.TabIndex = 7;
            this.domainUpDownKubikaza.Click += new System.EventHandler(this.domainUpDownKubikaza_Click);
            this.domainUpDownKubikaza.KeyDown += new System.Windows.Forms.KeyEventHandler(this.domainUpDownKubikaza_KeyDown);
            // 
            // buttonSnimi
            // 
            this.buttonSnimi.Location = new System.Drawing.Point(28, 207);
            this.buttonSnimi.Name = "buttonSnimi";
            this.buttonSnimi.Size = new System.Drawing.Size(75, 23);
            this.buttonSnimi.TabIndex = 8;
            this.buttonSnimi.Text = "Snimi";
            this.buttonSnimi.UseVisualStyleBackColor = true;
            this.buttonSnimi.Click += new System.EventHandler(this.buttonSnimi_Click);
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.Location = new System.Drawing.Point(183, 207);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(75, 23);
            this.buttonOtkazi.TabIndex = 9;
            this.buttonOtkazi.Text = "Otkaži";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            this.buttonOtkazi.Click += new System.EventHandler(this.buttonOtkazi_Click);
            // 
            // NoviAutomobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 247);
            this.Controls.Add(this.buttonOtkazi);
            this.Controls.Add(this.buttonSnimi);
            this.Controls.Add(this.domainUpDownKubikaza);
            this.Controls.Add(this.labelKubikaza);
            this.Controls.Add(this.comboBoxKlasa);
            this.Controls.Add(this.labelKlasa);
            this.Controls.Add(this.textBoxProizvodjac);
            this.Controls.Add(this.labelProizvodjac);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.labelModel);
            this.Name = "NoviAutomobil";
            this.Text = "Novi Automobil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label labelProizvodjac;
        private System.Windows.Forms.TextBox textBoxProizvodjac;
        private System.Windows.Forms.Label labelKlasa;
        private System.Windows.Forms.ComboBox comboBoxKlasa;
        private System.Windows.Forms.Label labelKubikaza;
        private System.Windows.Forms.DomainUpDown domainUpDownKubikaza;
        private System.Windows.Forms.Button buttonSnimi;
        private System.Windows.Forms.Button buttonOtkazi;
    }
}