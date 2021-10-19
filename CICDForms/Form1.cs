namespace CICDForms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            this.RealOutputBox.Text += 0;
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            this.RealOutputBox.Text += 1;
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            this.RealOutputBox.Text += 2;
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            this.RealOutputBox.Text += 3;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            this.RealOutputBox.Text += 4;
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            this.RealOutputBox.Text += 5;
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            this.RealOutputBox.Text += 6;
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            this.RealOutputBox.Text += 7;
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            this.RealOutputBox.Text += 8;
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            this.RealOutputBox.Text += 9;
        }

        private void button_division_Click(object sender, EventArgs e)
        {
            this.RealOutputBox.Text += "/";
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            this.RealOutputBox.Text += "=";
        }

        private void button_m1nus_Click(object sender, EventArgs e)
        {
            this.RealOutputBox.Text += "-";
        }

        private void button_muliplication_Click(object sender, EventArgs e)
        {
            this.RealOutputBox.Text += "*";
        }

        private void button_p1us_Click(object sender, EventArgs e)
        {
            this.RealOutputBox.Text += "+";
        }

        private void RealOutputBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}