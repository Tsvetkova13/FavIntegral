using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteIntegral
{
    public interface ICalculate
    {
        double Simpson(double a, double b, int n, Func<double, double> func);
        //double Rectangles(double a, double b, double h, CancellationToken token, IProgress<int> progress, Func<double, double> func);
    }
}
