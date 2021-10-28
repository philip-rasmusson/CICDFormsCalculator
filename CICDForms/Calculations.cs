namespace CICDForms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Calculations
    {
        public static int Input { get; set; }
        public static char Operand { get; set; }
        public static string TempInput { get; set; }
        public static int Value { get; set; } = 0;

        public static void Calculation(char op)
        {
           
            if (Input == Double.MinValue)
            {
                Input = Value;
            }
            if (op == '+')
            {
                
                Value = Plus(Input, Convert.ToInt32(TempInput));
                //Input = Double.MinValue;
                Input = int.MaxValue;
            }
            else if (op == '-')
            {
                Value = Minus(Input, Convert.ToInt32(TempInput));
                //Input = Double.MinValue;
                Input = int.MaxValue;
            }
            else if (op == '/')
            {
                if (TempInput != null)
                {
                Value = Division(Input, Convert.ToInt32(TempInput));
                    //Input = Double.MinValue;
                    Input = int.MaxValue;
                }
            }
            else if (op == '*')
            {
                Value = Multiply(Input, Convert.ToInt32(TempInput));
                //Input = Double.MinValue;
                Input = int.MaxValue;
            }
            //if (TempInput != null)
            //{
            //    TempInput = null;
            //}
        }

        public static int Division(int value1, int value2)
        {
            return (value1 / value2);
        }

        public static int Plus(int value1, int value2)
        {
            return value1 + value2;
        }

        public static int Minus(int value1, int value2)
        {
            return value1 - value2;
        }

        public static int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }

       
    }
}