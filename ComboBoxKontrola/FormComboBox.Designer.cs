namespace ComboBoxKontrola
{
    partial class FormComboBox
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
            this.comboBoxIzbor = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izaberite jedan od ponuđenih obrazovnih profila:";
            // 
            // comboBoxIzbor
            // 
            this.comboBoxIzbor.FormattingEnabled = true;
            this.comboBoxIzbor.Items.AddRange(new object[] {
            "IT Menadžment",
            "Aplikativno programiranje",
            "Internet programiranje",
            "Informacioni sistemi"});
            this.comboBoxIzbor.Location = new System.Drawing.Point(12, 69);
            this.comboBoxIzbor.Name = "comboBoxIzbor";
            this.comboBoxIzbor.Size = new System.Drawing.Size(260, 21);
            this.comboBoxIzbor.TabIndex = 1;
            this.comboBoxIzbor.SelectedIndexChanged += new System.EventHandler(this.comboBoxIzbor_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 2;
            // 
            // FormComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 173);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxIzbor);
            this.Controls.Add(this.label1);
            this.Name = "FormComboBox";
            this.Text = "Upotreba ComboBox Kontrole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxIzbor;
        private System.Windows.Forms.TextBox textBox1;
    }
}

