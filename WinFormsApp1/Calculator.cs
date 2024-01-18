using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Calculator
    {
        public double Plus(double calValue1, double calValue2)
        {
            return calValue1 + calValue2;
        }

        public double Minus(double calValue1, double calValue2)
        {
            return calValue1 - calValue2;
        }

        public double Multiply(double calValue1, double calValue2)
        {
            return calValue1 * calValue2;
        }

        public double Divide(double calValue1, double calValue2)
        {
            return calValue1 / calValue2;
        }

        public double Root(double calValue)
        {
            return Math.Sqrt(calValue);
        }

        public double Sqaure(double calValue)
        {
            return Math.Pow(calValue, 2);
        }

        public double Reciprocal(double calValue)
        {
            return 1 / calValue;
        }
    }
}
