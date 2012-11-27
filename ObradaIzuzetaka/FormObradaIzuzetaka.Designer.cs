namespace ObradaIzuzetaka
{
    partial class FormObradaIzuzetaka
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
            this.Prvi = new System.Windows.Forms.Label();
            this.Drugi = new System.Windows.Forms.Label();
            this.textBoxPrviBroj = new System.Windows.Forms.TextBox();
            this.textBoxDrugiBroj = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Prvi
            // 
            this.Prvi.AutoSize = true;
            this.Prvi.Location = new System.Drawing.Point(26, 27);
            this.Prvi.Name = "Prvi";
            this.Prvi.Size = new System.Drawing.Size(46, 13);
            this.Prvi.TabIndex = 0;
            this.Prvi.Text = "Prvi Broj";
            // 
            // Drugi
            // 
            this.Drugi.AutoSize = true;
            this.Drugi.Location = new System.Drawing.Point(26, 72);
            this.Drugi.Name = "Drugi";
            this.Drugi.Size = new System.Drawing.Size(55, 13);
            this.Drugi.TabIndex = 1;
            this.Drugi.Text = "Drugi broj:";
            // 
            // textBoxPrviBroj
            // 
            this.textBoxPrviBroj.Location = new System.Drawing.Point(135, 20);
            this.textBoxPrviBroj.Name = "textBoxPrviBroj";
            this.textBoxPrviBroj.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrviBroj.TabIndex = 2;
            // 
            // textBoxDrugiBroj
            // 
            this.textBoxDrugiBroj.Location = new System.Drawing.Point(135, 65);
            this.textBoxDrugiBroj.Name = "textBoxDrugiBroj";
            this.textBoxDrugiBroj.Size = new System.Drawing.Size(100, 20);
            this.textBoxDrugiBroj.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Izračunaj zbir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormObradaIzuzetaka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 151);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDrugiBroj);
            this.Controls.Add(this.textBoxPrviBroj);
            this.Controls.Add(this.Drugi);
            this.Controls.Add(this.Prvi);
            this.Name = "FormObradaIzuzetaka";
            this.Text = "Obrada Izuzetaka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Prvi;
        private System.Windows.Forms.Label Drugi;
        private System.Windows.Forms.TextBox textBoxPrviBroj;
        private System.Windows.Forms.TextBox textBoxDrugiBroj;
        private System.Windows.Forms.Button button1;
    }
}

