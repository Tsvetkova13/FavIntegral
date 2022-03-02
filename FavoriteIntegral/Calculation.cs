using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Integration;

namespace FavoriteIntegral
{
    public class Calculation:ICalculate
    {
        public double Simpson(double a, double b, int n, Func<double, double> func)
        {
            double res=0.0;
            if ((a!=0)&&(b!=0)&&(n!=0)&&(a < b)&&(a!=b)&&(n%2==0))
            {
                res = SimpsonRule.IntegrateComposite(func, a, b, n);
            }
            else
            {
                throw new Exception();
            }
            return res; 
           
        }

    }
}
