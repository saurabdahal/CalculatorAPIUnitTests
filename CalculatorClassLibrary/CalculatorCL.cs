using System.Runtime.InteropServices;

namespace CalculatorClassLibrary
{
    public class CalculatorCL
    {
        
        public decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public decimal Subtract(decimal smallnumber, decimal bignumber)
        {
            if (bignumber < smallnumber) { return 0.0m; }
            return bignumber - smallnumber;
        }

        public decimal Multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        public decimal Divide(decimal smallnumber, decimal bignumber)
        {
            if (bignumber < smallnumber) { return 0m; }
            return bignumber / smallnumber;
        }

        public decimal Modulo(decimal smallnumber, decimal bignumber)
        {
            if (bignumber < smallnumber) { return 0m; }
            return bignumber % smallnumber;
        }
    }
}
