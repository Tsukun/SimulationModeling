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
        double TheorPoisson(double p,int m )
        {
            double n = Math.Floor(m / p);
            double a = p * n;
            double P = (Math.Pow(a, m)/factorial(m))*Math.Exp(-a);
            return Math.Floor(P*n);
        }
        int EmpPoisson(int m,double P)
        {
            double n;
            int count=0;
            Random ran = new Random();
            n = Math.Floor(m/ P);
            for (int i = 0; i < n; i++)
            {
                double E = ran.NextDouble();
                if (P > E)
                   count++;
            }

            return count;
        }
       int ModPoisson(int m)
        {
            int k = 1;
            Random rand = new Random();
            double randnumber=rand.NextDouble();
            if (randnumber < Math.Exp(-m))
                return 0;  

            while (randnumber > Math.Exp(-m))
            {
                randnumber *= rand.NextDouble();
                k++;
            }
            return k;   
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            double P = 0.1 + ran.NextDouble() % 0.1;
            textBox1.Text= "EmpPoison number ="+EmpPoisson(3,P).ToString()+'\r'+'\n';
            textBox1.Text += "TheorPoison number=" + TheorPoisson(P, 3) + '\r' + '\n';
            textBox1.Text += "ModPoison number=" + ModPoisson(3) ;

        }

        
    }
 
}
