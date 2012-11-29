namespace CheckBoxKontrola
{
    partial class FormCheckBox
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
            this.checkBoxDorucak = new System.Windows.Forms.CheckBox();
            this.checkBoxRucak = new System.Windows.Forms.CheckBox();
            this.checkBoxVecera = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxSakri = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxDorucak
            // 
            this.checkBoxDorucak.AutoSize = true;
            this.checkBoxDorucak.Location = new System.Drawing.Point(13, 13);
            this.checkBoxDorucak.Name = "checkBoxDorucak";
            this.checkBoxDorucak.Size = new System.Drawing.Size(67, 17);
            this.checkBoxDorucak.TabIndex = 0;
            this.checkBoxDorucak.Text = "Doručak";
            this.checkBoxDorucak.UseVisualStyleBackColor = true;
            // 
            // checkBoxRucak
            // 
            this.checkBoxRucak.AutoSize = true;
            this.checkBoxRucak.Location = new System.Drawing.Point(13, 62);
            this.checkBoxRucak.Name = "checkBoxRucak";
            this.checkBoxRucak.Size = new System.Drawing.Size(58, 17);
            this.checkBoxRucak.TabIndex = 1;
            this.checkBoxRucak.Text = "Ručak";
            this.checkBoxRucak.UseVisualStyleBackColor = true;
            // 
            // checkBoxVecera
            // 
            this.checkBoxVecera.AutoSize = true;
            this.checkBoxVecera.Location = new System.Drawing.Point(13, 114);
            this.checkBoxVecera.Name = "checkBoxVecera";
            this.checkBoxVecera.Size = new System.Drawing.Size(60, 17);
            this.checkBoxVecera.TabIndex = 2;
            this.checkBoxVecera.Text = "Večera";
            this.checkBoxVecera.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pošalji";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 118);
            this.textBox1.TabIndex = 4;
            // 
            // checkBoxSakri
            // 
            this.checkBoxSakri.AutoSize = true;
            this.checkBoxSakri.Location = new System.Drawing.Point(117, 161);
            this.checkBoxSakri.Name = "checkBoxSakri";
            this.checkBoxSakri.Size = new System.Drawing.Size(105, 17);
            this.checkBoxSakri.TabIndex = 5;
            this.checkBoxSakri.Text = "Sakri porudžbinu";
            this.checkBoxSakri.UseVisualStyleBackColor = true;
            this.checkBoxSakri.CheckedChanged += new System.EventHandler(this.checkBoxSakri_CheckedChanged);
            // 
            // FormCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 190);
            this.Controls.Add(this.checkBoxSakri);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxVecera);
            this.Controls.Add(this.checkBoxRucak);
            this.Controls.Add(this.checkBoxDorucak);
            this.Name = "FormCheckBox";
            this.Text = "Upotreba CheckBox Kontrole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDorucak;
        private System.Windows.Forms.CheckBox checkBoxRucak;
        private System.Windows.Forms.CheckBox checkBoxVecera;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxSakri;
    }
}

