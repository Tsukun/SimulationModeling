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
        int[] TheorPoisson(double p, double mx)
        {
            int n = (int)Math.Floor(mx / p);
            int countiter = Convert.ToInt32(textBox3.Text);
            int countInterval = Convert.ToInt32(textBox4.Text);
            int[] arr = new int[n];
            double P;
            for (int i = 0; i < countiter; i++) 
            {              
               
                for (int j = 0; j < n; j++) 
                {
                    P = (Math.Pow(mx, j) / factorial(j)) * Math.Exp(-mx);
                    double ran = rand.NextDouble();
                    if (ran<=P)
                       arr[j] +=1;
                }
               
            }
            for (int i = 0; i < n; i++)
                chart3.Series[0].Points.AddXY(i, arr[i]);
            return arr;
        }
        int[] EmpPoisson(double m, double P)
        {
            int n = (int)Math.Floor(m / P);
            int countiter= Convert.ToInt32(textBox3.Text);
            int countInterval = Convert.ToInt32(textBox4.Text);
            int[] arr = new int[countiter];
            int[] freq = new int[countInterval+1];
            for (int j = 0; j < countiter; j++)
            {
                int counter = 0;
                for (int i = 0; i < n; i++)
                {
                    double E = rand.NextDouble();
                    if (P > E)
                    {
                        counter++;
                    }
                }
                arr[j] = counter;
            }
          
                for (int j = 0; j < countInterval + 1; j++) 
                {

                for (int i = 0; i < countiter; i++)
                {
                    if (arr[i] == j)
                        freq[j] += 1;
                }
                }
            

                for (int i = 0; i < countInterval+1; i++)
                chart2.Series[0].Points.AddXY(i, freq[i]);

            return freq;
        }
        int[] ModPoisson(double m)
        {
            int countiter = Convert.ToInt32(textBox3.Text);
            int countInterval = Convert.ToInt32(textBox4.Text);
            int[] arr = new int[countiter];
            int[] freq = new int[countInterval + 1];
            for (int i = 0; i < countiter; i++)
            {
                double randnumber = rand.NextDouble();
                int k = 0;
                while (randnumber > Math.Exp(-m))
                {
                    randnumber *= rand.NextDouble();
                    k++;
                }
                arr[i] =k;
            }
            for (int j = 0; j < countInterval + 1; j++)
            {
                for (int i = 0; i < countiter; i++)
                {
                    if (arr[i] == j)
                        freq[j] += 1;
                }
            }
            for (int i = 0; i < countInterval + 1; i++)
                chart1.Series[0].Points.AddXY(i, freq[i]);
            return freq;
        }

        double CriterionPearson(int[] v1, int[] v2)
        {
            double xi=0;
            for (int i = 0; i < v1.Length; i++) 
            {
                if(v2[i]!=0)
                xi+= Math.Pow((v1[i] - v2[i]), 2) / v2[i];
            }
            return xi;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            chart3.Series[0].Points.Clear();
            double mx = Convert.ToInt32(textBox2.Text);
            double P = 0.2;
            int[] theorArray = TheorPoisson(P, mx);
            double xiemp = CriterionPearson(EmpPoisson(mx,P),theorArray);
            double ximod = CriterionPearson(ModPoisson(mx), theorArray);
            textBox1.Text = "P =" + P + '\r' + '\n';
            textBox1.Text += "Метод Пуассона критерий xi^2=" + xiemp+ '\r' + '\n';
            textBox1.Text += "Модифицированный метод Пуассона критерий xi^2=" + ximod + '\r' + '\n';
        }

    }

}
