namespace CICDForms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Calculations
    {
        public static string Input { get; set; }
        public static char Operand { get; set; }
        public static string TempInput { get; set; }
        public static int Value { get; set; } = 0;

        public static void Calculation(char op)
        {
            //if (Value == 0)
            //{
            //    Value = Convert.ToInt32(TempInput);
            //}
            if (op == '+')
            {
                Value += Convert.ToInt32(TempInput);
            }
            else if (op == '-')
            {
                Value -= Convert.ToInt32(TempInput);
            }
            else if (op == '/')
            {
                Value /= Convert.ToInt32(TempInput);
            }
            else if (op == '*')
            {
                Value *= Convert.ToInt32(TempInput);
            }
            if (TempInput != null)
            {
                TempInput = null;
            }
        }

        public static void ClearInput()
        {
            Value = 0;
            Operand = '0';
        }
    }
}