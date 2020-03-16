using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int factorial(int x)
        {
            if (x > 1)
                x *= factorial(x - 1);

            return x;
        }
        double TheorPoisson(double p, int m)
        {
            double n = Math.Floor(m / p);
            double a = p * n;
            double P = (Math.Pow(a, m) / factorial(m)) * Math.Exp(-a);
            return P;
        }
        double EmpPoisson(int m, double P)
        {
            int i;
            double n;
            int count = 0;
            Random ran = new Random();
            n = Math.Floor(m / P);

            for (i = 0; i < n; i++)
            {
                double E = ran.NextDouble();
                if (P > E)
                    count++;
            }

            return (double)count / (i + 1);
        }
        double ModPoisson(int m)
        {
            int k = 1;
            Random rand = new Random();
            double randnumber = rand.NextDouble();
            if (randnumber < Math.Exp(-m))
                return 1;

            while (randnumber > Math.Exp(-m))
            {
                randnumber *= rand.NextDouble();
                k++;
            }
            return (double)1 / k;
        }

        double CriterionPearson(double v1, double v2)
        {
            double xi = Math.Pow((v1 - v2 * 0.5f), 2) / v2 * 0.5f;
            return xi;
        }
        bool Compare(double xi1, double xi2)
        {
            return xi1 < xi2;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            double P = 0.1 + ran.NextDouble() % 0.1;
            double emp = EmpPoisson(3, P);
            double theor = TheorPoisson(P, 3);
            double mod = ModPoisson(3);
            textBox1.Text = "EmpPoison number =" + emp + '\r' + '\n';
            textBox1.Text += "TheorPoison number=" + theor + '\r' + '\n';
            textBox1.Text += "ModPoison number=" + mod + '\r' + '\n';
            textBox1.Text += "Poison > ModPoison? " + Compare(CriterionPearson(emp, theor), CriterionPearson(mod, theor));
        }


    }

}
