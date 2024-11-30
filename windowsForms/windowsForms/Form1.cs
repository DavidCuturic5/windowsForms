using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsForms
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxDorucak = new CheckBox();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            textBox1.Clear();



            // poziv metode AppendText() za dodavanje sadrzaja u text box

            textBox1.AppendText("Odabrali ste :" + Environment.NewLine);

            if (checkBoxDorucak.Checked)

                textBox1.AppendText("dorucak" + Environment.NewLine);

            if (checkBoxRucak.Checked)

                textBox1.AppendText("rucak" + Environment.NewLine);

            if (checkBoxVecera.Checked)

                textBox1.AppendText("vecera" + Environment.NewLine);
        }

        private void checkBoxSakrij_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Visible == false)

                textBox1.Visible = true;

            else

                textBox1.Visible = false;
        }
    }
}
