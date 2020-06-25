using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double znach = Convert.ToDouble(textBox1.Text);
            long n = 1;
            for (int i = 0; i < znach; i++)
            {
                n= n * 2;
            }
            if (znach >62)
            {
                label2.Text = "Ошибка.Введите меньше число";
            }
            else
            {
                label2.Text = n.ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                button2.Enabled = true;           
            }
            else
                button2.Enabled = false;
        }

    }
}
