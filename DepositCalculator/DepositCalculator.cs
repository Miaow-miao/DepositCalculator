using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositCalculator
{
    public static class Calculator
    {
        public static double Simple(double P, double rate, int months)
        {
            double t = months / 12.0;
            return P * (1 + rate * t);
        }

        public static double Compound(double P, double rate, int months)
        {
            return P * Math.Pow(1 + rate / 12, months);
        }
    }
}