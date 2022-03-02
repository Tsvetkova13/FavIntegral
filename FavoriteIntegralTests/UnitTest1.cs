using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FavoriteIntegral;

namespace FavoriteIntegralTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        [ExpectedException(typeof(Exception))]
        public void TestCountN()
        {
            //assert 
            Func<double, double> func = x => x * x;
            double a = 0;
            double b = 4;
            int n = 0;

            //act
            ICalculate math = new Calculation();
            double res = math.Simpson(a, b, n, func);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestWrongLowBorder()
        {
            //assert 
            Func<double, double> func = x => x * x;
            double a = 6;
            double b = 4;
            int n = 10;

            //act
            ICalculate math = new Calculation();
            double res = math.Simpson(a, b, n, func);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestWrongBorder()
        {
            //assert 
            Func<double, double> func = x => x * x;
            double a = 4;
            double b = 4;
            int n = 10;

            //act
            ICalculate math = new Calculation();
            double res = math.Simpson(a, b, n, func);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestWrongAllArgument()
        {
            //assert 
            Func<double, double> func = x => x * x;
            double a = 0;
            double b = 0;
            int n = 0;

            //act
            ICalculate math = new Calculation();
            double res = math.Simpson(a, b, n, func);
        }

        [TestMethod]

        [ExpectedException(typeof(Exception))]
        public void TestRightN()
        {
            //assert 
            Func<double, double> func = x => x * x;
            double a = 0;
            double b = 4;
            int n = 3;

            //act
            ICalculate math = new Calculation();
            double res = math.Simpson(a, b, n, func);
        }
    }
}
