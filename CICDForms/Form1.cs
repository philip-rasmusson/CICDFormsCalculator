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

        private void Button_0_Click(object sender, EventArgs e)
        {
            Calculations.TempInput += "0";
            this.RealOutputBox.Text = Calculations.TempInput;
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            Calculations.TempInput += "1";
            this.RealOutputBox.Text = Calculations.TempInput;
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            Calculations.TempInput += "2";
            this.RealOutputBox.Text = Calculations.TempInput;
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            Calculations.TempInput += "3";
            this.RealOutputBox.Text = Calculations.TempInput;
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            Calculations.TempInput += "4";
            this.RealOutputBox.Text = Calculations.TempInput;
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            Calculations.TempInput += "5";
            this.RealOutputBox.Text = Calculations.TempInput;
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            Calculations.TempInput += "6";
            this.RealOutputBox.Text = Calculations.TempInput;
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            Calculations.TempInput += "7";
            this.RealOutputBox.Text = Calculations.TempInput;
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            Calculations.TempInput += "8";
            this.RealOutputBox.Text = Calculations.TempInput;
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            Calculations.TempInput += "9";
            this.RealOutputBox.Text = Calculations.TempInput;
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            Calculations.ClearInput();
            this.RealOutputBox.Text = "";
        }

        private void Button_Division_Click(object sender, EventArgs e)
        {
            Calculations.Operand = '/';
            Calculations.Input = Calculations.TempInput;
            this.RealOutputBox.Text = Convert.ToString(Calculations.Operand);
            Calculations.Calculation(Calculations.Operand);
        }

        private void Button_Equals_Click(object sender, EventArgs e)
        {
            Calculations.Calculation(Calculations.Operand);
            this.RealOutputBox.Text = Calculations.Value.ToString();
        }

        private void Button_Minus_Click(object sender, EventArgs e)
        {
            Calculations.Operand = '-';
            Calculations.Input = Calculations.TempInput;
            this.RealOutputBox.Text = Convert.ToString(Calculations.Operand);
            Calculations.Calculation(Calculations.Operand);
        }

        private void Button_Multiplication_Click(object sender, EventArgs e)
        {
            Calculations.Operand = '*';
            Calculations.Input = Calculations.TempInput;
            this.RealOutputBox.Text = Convert.ToString(Calculations.Operand);
            Calculations.Calculation(Calculations.Operand);
        }

        private void Button_Plus_Click(object sender, EventArgs e)
        {
            Calculations.Operand = '+';
            Calculations.Input = Calculations.TempInput;
            this.RealOutputBox.Text = Convert.ToString(Calculations.Operand);
            Calculations.Calculation(Calculations.Operand);
        }

        private void RealOutputBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}