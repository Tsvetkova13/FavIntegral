using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Symbolics;

namespace FavoriteIntegral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Simpson() // функция рассчёта 
        {
            double res = 0.0;

            if ((LowBorder.Text != "") && (UpBorder.Text != "") && (countN.Text != "")&&(Func.Text!=""))
            {
                Calculation c = new Calculation();
                

                double low = Convert.ToDouble(LowBorder.Text);
                double Up = Convert.ToDouble(UpBorder.Text);
                int N = Convert.ToInt32(countN.Text);
                Func<double, double> f = SymbolicExpression.Parse(Func.Text).Compile("x");

                res = c.Simpson(low, Up, N, f);
            }
            else
            {
                throw new Exception();
            }

            return res;
        }

        private void btCount_Click(object sender, EventArgs e)
        {
            double res = Simpson();
            Result.Text = Convert.ToString(res);
        }
    }
}
