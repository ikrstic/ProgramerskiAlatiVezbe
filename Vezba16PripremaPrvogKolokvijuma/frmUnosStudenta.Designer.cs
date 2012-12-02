namespace Vezba16PripremaPrvogKolokvijuma
{
    partial class frmUnosStudenta
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
            this.butonSnimi_Click = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButtonMuski = new System.Windows.Forms.RadioButton();
            this.radioButtonZenski = new System.Windows.Forms.RadioButton();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxGod = new System.Windows.Forms.TextBox();
            this.comboBoxSmer = new System.Windows.Forms.ComboBox();
            this.groupBoxPol = new System.Windows.Forms.GroupBox();
            this.groupBoxPol.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Smer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime i prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Godina rođenja:";
            // 
            // butonSnimi_Click
            // 
            this.butonSnimi_Click.Location = new System.Drawing.Point(12, 200);
            this.butonSnimi_Click.Name = "butonSnimi_Click";
            this.butonSnimi_Click.Size = new System.Drawing.Size(75, 23);
            this.butonSnimi_Click.TabIndex = 6;
            this.butonSnimi_Click.Text = "Prihvati";
            this.butonSnimi_Click.UseVisualStyleBackColor = true;
            this.butonSnimi_Click.Click += new System.EventHandler(this.butonSnimi_Click_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Otkaži";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(197, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Zatvori";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButtonMuski
            // 
            this.radioButtonMuski.AutoSize = true;
            this.radioButtonMuski.Location = new System.Drawing.Point(18, 19);
            this.radioButtonMuski.Name = "radioButtonMuski";
            this.radioButtonMuski.Size = new System.Drawing.Size(53, 17);
            this.radioButtonMuski.TabIndex = 9;
            this.radioButtonMuski.TabStop = true;
            this.radioButtonMuski.Text = "Muški";
            this.radioButtonMuski.UseVisualStyleBackColor = true;
            // 
            // radioButtonZenski
            // 
            this.radioButtonZenski.AutoSize = true;
            this.radioButtonZenski.Location = new System.Drawing.Point(89, 19);
            this.radioButtonZenski.Name = "radioButtonZenski";
            this.radioButtonZenski.Size = new System.Drawing.Size(57, 17);
            this.radioButtonZenski.TabIndex = 10;
            this.radioButtonZenski.TabStop = true;
            this.radioButtonZenski.Text = "Ženski";
            this.radioButtonZenski.UseVisualStyleBackColor = true;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(101, 52);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(171, 20);
            this.textBoxIme.TabIndex = 12;
            // 
            // textBoxGod
            // 
            this.textBoxGod.Location = new System.Drawing.Point(101, 92);
            this.textBoxGod.Name = "textBoxGod";
            this.textBoxGod.Size = new System.Drawing.Size(100, 20);
            this.textBoxGod.TabIndex = 13;
            // 
            // comboBoxSmer
            // 
            this.comboBoxSmer.FormattingEnabled = true;
            this.comboBoxSmer.Items.AddRange(new object[] {
            "Informacione tehnologije",
            "Elektronsko poslovanje",
            "Racunarska multimedija",
            "Organizacija poslovnih sistema"});
            this.comboBoxSmer.Location = new System.Drawing.Point(101, 9);
            this.comboBoxSmer.Name = "comboBoxSmer";
            this.comboBoxSmer.Size = new System.Drawing.Size(171, 21);
            this.comboBoxSmer.TabIndex = 14;
            // 
            // groupBoxPol
            // 
            this.groupBoxPol.Controls.Add(this.radioButtonMuski);
            this.groupBoxPol.Controls.Add(this.radioButtonZenski);
            this.groupBoxPol.Location = new System.Drawing.Point(12, 134);
            this.groupBoxPol.Name = "groupBoxPol";
            this.groupBoxPol.Size = new System.Drawing.Size(167, 49);
            this.groupBoxPol.TabIndex = 15;
            this.groupBoxPol.TabStop = false;
            this.groupBoxPol.Text = "Pol";
            // 
            // frmUnosStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 235);
            this.Controls.Add(this.groupBoxPol);
            this.Controls.Add(this.comboBoxSmer);
            this.Controls.Add(this.textBoxGod);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.butonSnimi_Click);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUnosStudenta";
            this.Text = "Novi student";
            this.groupBoxPol.ResumeLayout(false);
            this.groupBoxPol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butonSnimi_Click;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButtonMuski;
        private System.Windows.Forms.RadioButton radioButtonZenski;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxGod;
        private System.Windows.Forms.ComboBox comboBoxSmer;
        private System.Windows.Forms.GroupBox groupBoxPol;
    }
}