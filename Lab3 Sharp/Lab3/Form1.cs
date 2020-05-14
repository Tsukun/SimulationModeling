using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.ScrollBars = ScrollBars.Both;
        }
        public void setStat(int allPatient, double averageTime, double averageLoad, List<double> dynamic)
        {
            if (dynamic != null)
            {
                allPat.Series[0].Points.AddXY(0, allPatient);
                averTime.Series[0].Points.AddXY(0, averageTime);
                averLoad.Series[0].Points.AddXY(0, averageLoad);
                for (int i = 0; i < dynamic.Count; i++)
                    dynam.Series[0].Points.AddXY(i, dynamic[i]);
            }
            else
            {
                allPat.Series[1].Points.AddXY(1, allPatient);
                averTime.Series[1].Points.AddXY(1, averageTime);
                averLoad.Series[1].Points.AddXY(1, averageLoad);
            }
        }
        public void setText(string s)
        {
            textBox1.Text += s;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            allPat.Series[0].Points.Clear();
            allPat.Series[1].Points.Clear();
            averTime.Series[0].Points.Clear();
            averTime.Series[1].Points.Clear();
            averLoad.Series[0].Points.Clear();
            averLoad.Series[1].Points.Clear();
            dynam.Series[0].Points.Clear();
            textBox1.Text = "";
            int dayCount = Convert.ToInt32(numericUpDown1.Value);
            Hospital<DtPatient> hospDt = new Hospital<DtPatient>();
            hospDt.setForm(this);
            hospDt.setCountDay(dayCount);
            for (int i = 0; i < dayCount; i++)
            {
                hospDt.arravial(1);
                hospDt.discharge(49,25);
                textBox1.Text +="Day "+(i+1)+"\r\n";
                hospDt.printArr();
            }
            hospDt.statistic(1);

            Hospital<SpecialPatient> hospSpec = new Hospital<SpecialPatient>();
            hospSpec.setForm(this);
            hospSpec.setCountDay(dayCount);
            for (int i = 0; i < dayCount; i++)
            {
                hospSpec.arravial(2);
                hospSpec.discharge(49, 25);
                textBox1.Text += "Day " + (i + 1) + "\r\n";
                hospSpec.printArr();
            }
            hospSpec.statistic(2);
        }

    }
}
