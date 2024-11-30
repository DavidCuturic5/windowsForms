namespace windowsForms
{
    partial class Form1
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
            this.checkBoxSakrij = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxDorucak
            // 
            this.checkBoxDorucak.AutoSize = true;
            this.checkBoxDorucak.Location = new System.Drawing.Point(8, 12);
            this.checkBoxDorucak.Name = "checkBoxDorucak";
            this.checkBoxDorucak.Size = new System.Drawing.Size(67, 17);
            this.checkBoxDorucak.TabIndex = 0;
            this.checkBoxDorucak.Text = "Dorucak";
            this.checkBoxDorucak.UseVisualStyleBackColor = true;
            this.checkBoxDorucak.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxRucak
            // 
            this.checkBoxRucak.AutoSize = true;
            this.checkBoxRucak.Location = new System.Drawing.Point(8, 48);
            this.checkBoxRucak.Name = "checkBoxRucak";
            this.checkBoxRucak.Size = new System.Drawing.Size(58, 17);
            this.checkBoxRucak.TabIndex = 1;
            this.checkBoxRucak.Text = "Rucak";
            this.checkBoxRucak.UseVisualStyleBackColor = true;
            // 
            // checkBoxVecera
            // 
            this.checkBoxVecera.AutoSize = true;
            this.checkBoxVecera.Location = new System.Drawing.Point(8, 88);
            this.checkBoxVecera.Name = "checkBoxVecera";
            this.checkBoxVecera.Size = new System.Drawing.Size(60, 17);
            this.checkBoxVecera.TabIndex = 2;
            this.checkBoxVecera.Text = "Vecera";
            this.checkBoxVecera.UseVisualStyleBackColor = true;
            // 
            // checkBoxSakrij
            // 
            this.checkBoxSakrij.AutoSize = true;
            this.checkBoxSakrij.Location = new System.Drawing.Point(138, 205);
            this.checkBoxSakrij.Name = "checkBoxSakrij";
            this.checkBoxSakrij.Size = new System.Drawing.Size(99, 17);
            this.checkBoxSakrij.TabIndex = 3;
            this.checkBoxSakrij.Text = "Sakrij narudžbu";
            this.checkBoxSakrij.UseVisualStyleBackColor = true;
            this.checkBoxSakrij.CheckedChanged += new System.EventHandler(this.checkBoxSakrij_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Posalji";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 160);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 251);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxSakrij);
            this.Controls.Add(this.checkBoxVecera);
            this.Controls.Add(this.checkBoxRucak);
            this.Controls.Add(this.checkBoxDorucak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDorucak;
        private System.Windows.Forms.CheckBox checkBoxRucak;
        private System.Windows.Forms.CheckBox checkBoxVecera;
        private System.Windows.Forms.CheckBox checkBoxSakrij;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

