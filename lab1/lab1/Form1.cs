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
        static Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        int factorial(int x)
        {
            if (x > 1)
                x *= factorial(x - 1);
            
            if (x == 0)
                return 1;

            return x;
        }
        double TheorPoisson(double p, double mx)
        {
            double n = Math.Floor(mx / p);
            int m =(int)Math.Floor(p * n);
            double P = (Math.Pow(mx, m) / factorial(m)) * Math.Exp(-mx);
            return P;
        }
        double EmpPoisson(double m, double P)
        {
            int i;
            int n;
            int countinter= Convert.ToInt32(textBox3.Text);
            double[] interval = new double[countinter];
            int[] temp = new int[countinter];
            interval[0] = P/ countinter;
            for (int j = 1; j < countinter; j++)
                interval[j] = interval[0] + interval[0] * j;
            int count = 0;
            n = (int)Math.Floor(m / P);
            double[] arr = new double[n];
            for (i = 0; i < n; i++)
            {
                double E = rand.NextDouble();
                if (P > E)
                {
                    count++;
                    arr[i] = E;
                }
                
            }
            for (int k = 0; k < countinter; k++)
                for (int j = 0; j < n; j++)
                    if (arr[j] < interval[k])
                    {
                        temp[k]++;
                        break;
                    }

            for (int j = 0; j < countinter; j++)
                chart2.Series[0].Points.AddXY(interval[j], temp[j]);
            return (double)count / (i + 1);
        }
        double ModPoisson(double m)
        {
            int k = 1;
            double randnumber = rand.NextDouble();
            if (randnumber < Math.Exp(-m))
                return 1;

            while (randnumber > Math.Exp(-m))
            {
                randnumber *= rand.NextDouble();
                k++;
                chart1.Series[0].Points.AddXY(k, randnumber);
            }
            return (double)1 / k;
        }

        double CriterionPearson(double v1, double v2)
        {
            double xi = Math.Pow((v1 - v2 * 0.5f), 2) / (v2 * 0.5f);
            return xi;
        }
        bool Compare(double xi1, double xi2)
        {
            return xi1 < xi2;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            double mx = Convert.ToInt32(textBox2.Text);
            //Random ran = new Random();
            double P = 0.1 + rand.NextDouble() % 0.1;
            double emp = EmpPoisson(mx, P);
            double theor = TheorPoisson(P, mx);
            double mod = ModPoisson(mx);
            textBox1.Text = "EmpPoison frequency =" + emp + '\r' + '\n';
            textBox1.Text += "TheorPoison frequency=" + theor + '\r' + '\n';
            textBox1.Text += "ModPoison frequency=" + mod + '\r' + '\n';
            textBox1.Text += "Poison > ModPoison? " + Compare(CriterionPearson(emp, theor), CriterionPearson(mod, theor));
        }

     
    }

}
