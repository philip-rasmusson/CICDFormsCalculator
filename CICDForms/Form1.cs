﻿namespace CICDForms
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
        private double FirstNumber;
        private string Operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            RealOutputBox.Text = RealOutputBox.Text + "0";
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            if (RealOutputBox.Text == "0" && RealOutputBox.Text != null)
            {
                RealOutputBox.Text = "1";
            }
            else
            {
                RealOutputBox.Text = RealOutputBox.Text + "1";
            }
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            if (RealOutputBox.Text == "0" && RealOutputBox.Text != null)
            {
                RealOutputBox.Text = "2";
            }
            else
            {
                RealOutputBox.Text = RealOutputBox.Text + "2";
            }
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            if (RealOutputBox.Text == "0" && RealOutputBox.Text != null)
            {
                RealOutputBox.Text = "3";
            }
            else
            {
                RealOutputBox.Text = RealOutputBox.Text + "3";
            }
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            if (RealOutputBox.Text == "0" && RealOutputBox.Text != null)
            {
                RealOutputBox.Text = "4";
            }
            else
            {
                RealOutputBox.Text = RealOutputBox.Text + "4";
            }
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            if (RealOutputBox.Text == "0" && RealOutputBox.Text != null)
            {
                RealOutputBox.Text = "5";
            }
            else
            {
                RealOutputBox.Text = RealOutputBox.Text + "5";
            }
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            if (RealOutputBox.Text == "0" && RealOutputBox.Text != null)
            {
                RealOutputBox.Text = "6";
            }
            else
            {
                RealOutputBox.Text = RealOutputBox.Text + "6";
            }
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            if (RealOutputBox.Text == "0" && RealOutputBox.Text != null)
            {
                RealOutputBox.Text = "7";
            }
            else
            {
                RealOutputBox.Text = RealOutputBox.Text + "7";
            }
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            if (RealOutputBox.Text == "0" && RealOutputBox.Text != null)
            {
                RealOutputBox.Text = "8";
            }
            else
            {
                RealOutputBox.Text = RealOutputBox.Text + "8";
            }
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            if (RealOutputBox.Text == "" && RealOutputBox.Text != null)
            {
                RealOutputBox.Text = "9";
            }
            else
            {
                RealOutputBox.Text = RealOutputBox.Text + "9";
            }
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            RealOutputBox.Text = "0";
        }

        private void Button_Division_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(RealOutputBox.Text);
            RealOutputBox.Text = "0";
            Operation = "/";
        }

        private void Button_Equals_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(RealOutputBox.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                RealOutputBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                RealOutputBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                RealOutputBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    RealOutputBox.Text = "Cannot divide by zero";
                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    RealOutputBox.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void Button_Minus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(RealOutputBox.Text);
            RealOutputBox.Text = "0";
            Operation = "-";
        }

        private void Button_Multiplication_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(RealOutputBox.Text);
            RealOutputBox.Text = "0";
            Operation = "*";
        }

        private void Button_Plus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(this.RealOutputBox.Text);
            RealOutputBox.Text = "0";
            Operation = "+";
        }
    }
}