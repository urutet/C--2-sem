using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Form1 : Form
    {
        Calculator calc = new Calculator();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox.Text = calc.Clear();
            DEC_value.Text = calc.Clear();
            BIN_value.Text = calc.Clear();
            OCT_value.Text = calc.Clear();
            HEX_value.Text = calc.Clear();
        }
        private void And_Click(object sender, EventArgs e)
        {
            textBox.Text += '&';
        }

        private void Or_Click(object sender, EventArgs e)
        {
            textBox.Text += '|';
        }

        private void Xor_Click(object sender, EventArgs e)
        {
            textBox.Text += '^';
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            try
            {
                textBox.Text = calc.Equal(textBox.Text);
                DEC_value.Text = calc.ShowInDecimal(textBox.Text);
                BIN_value.Text = calc.ShowInBinary(textBox.Text);
                OCT_value.Text = calc.ShowInBinary(textBox.Text);
                HEX_value.Text = calc.ShowInHexagonal(textBox.Text);
            }
            catch (FormatException except)
            {
                MessageBox.Show("Wrong format!");
            }
        }

        private void Not_Click(object sender, EventArgs e)
        {
            try
            {
                textBox.Text = calc.Not(textBox.Text);
            }
            catch(FormatException excep)
            {
                MessageBox.Show("Wrong format!");
            }
        }
    }
}
