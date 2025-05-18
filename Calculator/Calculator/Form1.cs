using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += button14.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string ifade = textBox1.Text;

            int isaretIndex = ifade.IndexOfAny(new char[] { '+', '-', 'X', '/' });
            if(isaretIndex != -1)
            {
                string sayi1Str = ifade.Substring(0, isaretIndex);
                char isaret = ifade[isaretIndex];
                string sayi2Str = ifade.Substring(isaretIndex + 1);

                if(int.TryParse(sayi1Str, out int sayi1)&& int.TryParse(sayi2Str, out int sayi2))
                {
                    int sonuc = 0;
                    switch (isaret)
                    {
                        case '+':
                            sonuc = sayi1 + sayi2;
                            break;
                        case '-':
                            sonuc = sayi1 - sayi2;
                            break;
                        case 'X':
                            sonuc = sayi1 * sayi2;
                            break;
                        case '/':
                            sonuc = sayi2 != 0 ? sayi1 / sayi2 : 0;
                            break;
                    }

                    textBox1.Text = sonuc.ToString();
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string ifade = textBox1.Text;

            int isaretIndex = ifade.IndexOfAny(new char[] { '+', '-', 'X', '/' });

            if(isaretIndex != -1)
            {
                string sayi1 = ifade.Substring(0, isaretIndex + 1);
                textBox1.Text = sayi1;
            }
        }
    }
}
