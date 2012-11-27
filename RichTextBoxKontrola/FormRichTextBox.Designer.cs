namespace RichTextBoxKontrola
{
    partial class FormRichTextBox
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
            this.buttonCitaj_Click = new System.Windows.Forms.Button();
            this.buttonBrisi_Click = new System.Windows.Forms.Button();
            this.buttonSacuvaj_Click = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonCitaj_Click
            // 
            this.buttonCitaj_Click.Location = new System.Drawing.Point(12, 12);
            this.buttonCitaj_Click.Name = "buttonCitaj_Click";
            this.buttonCitaj_Click.Size = new System.Drawing.Size(75, 23);
            this.buttonCitaj_Click.TabIndex = 0;
            this.buttonCitaj_Click.Text = "Čitaj";
            this.buttonCitaj_Click.UseVisualStyleBackColor = true;
            this.buttonCitaj_Click.Click += new System.EventHandler(this.buttonCitaj_Click_Click);
            // 
            // buttonBrisi_Click
            // 
            this.buttonBrisi_Click.Location = new System.Drawing.Point(197, 12);
            this.buttonBrisi_Click.Name = "buttonBrisi_Click";
            this.buttonBrisi_Click.Size = new System.Drawing.Size(75, 23);
            this.buttonBrisi_Click.TabIndex = 1;
            this.buttonBrisi_Click.Text = "Briši";
            this.buttonBrisi_Click.UseVisualStyleBackColor = true;
            this.buttonBrisi_Click.Click += new System.EventHandler(this.buttonBrisi_Click_Click);
            // 
            // buttonSacuvaj_Click
            // 
            this.buttonSacuvaj_Click.Location = new System.Drawing.Point(12, 227);
            this.buttonSacuvaj_Click.Name = "buttonSacuvaj_Click";
            this.buttonSacuvaj_Click.Size = new System.Drawing.Size(75, 23);
            this.buttonSacuvaj_Click.TabIndex = 2;
            this.buttonSacuvaj_Click.Text = "Sačuvaj";
            this.buttonSacuvaj_Click.UseVisualStyleBackColor = true;
            this.buttonSacuvaj_Click.Click += new System.EventHandler(this.buttonSacuvaj_Click_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(260, 180);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // FormRichTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonSacuvaj_Click);
            this.Controls.Add(this.buttonBrisi_Click);
            this.Controls.Add(this.buttonCitaj_Click);
            this.Name = "FormRichTextBox";
            this.Text = "Upotreba RichTextox Kontrole";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCitaj_Click;
        private System.Windows.Forms.Button buttonBrisi_Click;
        private System.Windows.Forms.Button buttonSacuvaj_Click;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

