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
        }
        private void And_Click(object sender, EventArgs e)
        {
            textBox.Text += '&';
        }

        private void Hex_Click(object sender, EventArgs e)
        {
            textBox.Text = calc.ShowInHexagonal(textBox.Text);
        }

        private void Or_Click(object sender, EventArgs e)
        {
            textBox.Text += '|';
        }

        private void Xor_Click(object sender, EventArgs e)
        {
            textBox.Text += '^';
        }

        private void Binary_Click(object sender, EventArgs e)
        {
            textBox.Text = calc.ShowInBinary(textBox.Text);
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            textBox.Text = calc.Equal(textBox.Text);
        }

        private void Not_Click(object sender, EventArgs e)
        {
            textBox.Text = calc.Not(textBox.Text);
        }

        private void Oct_Click(object sender, EventArgs e)
        {
            textBox.Text = calc.ShowInOctagonal(textBox.Text);
        }

        private void Dec_Click(object sender, EventArgs e)
        {
            textBox.Text = calc.ShowInDecimal(textBox.Text);
        }
    }
}
