using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_.NET_6._0
{
    public class Calc
    {
        // ADDITION
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Add(double[] a)
        {
            return a.Sum();
        }

        // SUBTRACTION
        public double Sub(double a, double b)
        {
            return a - b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Sub(int a, int b, int c)
        {
            return a - b - c;
        }

        // MULTIPLICATION
        public double Mul(double a, double b)
        {
            return a * b;
        }
        public double Mul(double a, double b, double c)
        {
            return a * b * c;
        }

        // DIVISION
        public double Div(double a, double b)
        {
            return a / b;
        }
        public double Div(double a, double b, double c)
        {
            return a / b/ c;
        }
    }
}
