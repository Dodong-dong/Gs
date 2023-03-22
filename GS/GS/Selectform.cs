using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GS
{
    public partial class Selectform : Form
    {
        public Selectform()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double totalPrice = double.Parse(TotalPriceTextBox.Text);
            double litersPumped = double.Parse(literspumpedTextBox.Text);

            double pricePerLiter = totalPrice / litersPumped;

            Liter.Text = $"Liter {pricePerLiter:0.00}";
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void Selectform_Load(object sender, EventArgs e)
        {

        }

        private void Liter_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double number = 62.20;
            literspumpedTextBox.Text += number;
        }

        private void literspumpedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = 1;
             TotalPriceTextBox.Text += number;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = 2;
            TotalPriceTextBox.Text += number;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number = 3;
            TotalPriceTextBox.Text += number;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number = 4;
            TotalPriceTextBox.Text += number;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int number = 5;
            TotalPriceTextBox.Text += number;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int number = 6;
            TotalPriceTextBox.Text += number;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int number = 7;
            TotalPriceTextBox.Text += number;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int number = 8;
            TotalPriceTextBox.Text += number;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int number = 9;
            TotalPriceTextBox.Text += number;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int number = 0;
            TotalPriceTextBox.Text += number;
        }
    }
}
    

