namespace CICDForms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Clear
    {
        public void ClearInput()
        {
            Calculations.Input = 0;
            Calculations.TempInput = null;
            Calculations.Value = 0;
            Calculations.Operand = '0';
        }
    }
}
