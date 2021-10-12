using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cpp_rand_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            radioButton3.Checked = true;
            textBox1.Text = 0.ToString();
            textBox2.Text = 0.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numb1 = 0;
            int numb2 = 0;
            
            int.TryParse(textBox1.Text, out numb1);
            int.TryParse(textBox2.Text, out numb2);
            if (numb1 == numb2 || numb2 < numb1) { MessageBox.Show("Špatně zadaný interval"); }
            else
            {
                int number1 = numb2 - numb1 + 0;
                if (radioButton4.Checked) { number1++; }
                int number2 = numb1;
                if (radioButton1.Checked) { number2++; number1--; }
                if ((radioButton1.Checked && radioButton3.Checked) && numb2 - numb1 == 1) { MessageBox.Show("Víš vůbec jak intervaly fungujou"); }
                else
                {
                    //MessageBox.Show("rand() % " + number1.ToString() + "+" + number2.ToString() + ";");
                    textBox3.Text = ("rand() % " + number1.ToString() + "+" + number2.ToString() + ";");
                    Clipboard.SetDataObject(textBox3.Text);
                }
            }
        }
    }
}
