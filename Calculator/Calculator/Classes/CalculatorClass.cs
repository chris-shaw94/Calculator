using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public double add(double A, double B)
        {
            return A + B;
        }
        public double sub(double A, double B)
        {
            return A - B;
        }
        public double div(double A, double B)
        {
            if (B > 0) {
                return A / B;
            }
            else
            {
                throw new Exception("Divide by zero error");
            }
        }
        public double mul(double A, double B)
        {
            return  A * B;
        }
    }
}
