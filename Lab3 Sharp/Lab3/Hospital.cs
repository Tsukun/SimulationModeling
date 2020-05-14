using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab3
{
	class Hospital<T> where T : Patient, new()
	{
		string s = "";
		Form1 form;
		Random rnd = new Random();
		T[] arr;
		List<double> load = new List<double>();
		List<double> dynamic = new List<double>();
		int averageTime = 0;
		int countPatient = 18;
		int allPatient = 18;
		int countDay = 1;
		int dischargePatient = 0;

		public Hospital()
		{
			arr = new T[25];
			for (int i = 0; i < countPatient; i++)
			{
				arr[i] = new T();
				arr[i].setHealth(30 + rnd.Next(10));
			}
		}

		public void setForm(Form1 f) { form = f; }
		public double NormRandom(double Mx, double Sigma)
		{
			double a, b, r, Sq;
			do
			{
				a = 2.0 * rnd.NextDouble() - 1.0;
				b = 2.0 * rnd.NextDouble() - 1.0;
				r = a * a + b * b;
			} while (r >= 1);
			Sq = Math.Sqrt(-2.0 * Math.Log(r) / r);
			return Mx + Sigma * a * Sq;
		}

		public void arravial(int k)
		{
			for (int i = 0; i < countPatient; i++)
			{
				arr[i].healthUp();
			}
			if (k == 1)
			{
				for (int i = 0; i < 2; i++)
				{
					if (countPatient != 25)
					{
						arr[countPatient] = new T();
						arr[countPatient].setHealth(20);
						arr[countPatient].setTime(0);
						countPatient++;
						allPatient++;
					}
					else
					{
						discharge(47,2);
						if (countPatient != 25)
						{
							arr[countPatient] = new T();
							arr[countPatient].setHealth(20);
							arr[countPatient].setTime(0);
							countPatient++;
							allPatient++;
						}

					}

				}
				dynamic.Add(countPatient);
			}

			if (k == 2)
			{
				int tempCount = (int)Math.Floor(NormRandom(2, 1) + 0.5);
				for (int i = 0; i < tempCount; i++)
				{
					double health = rnd.NextDouble()*44;
					if (countPatient < 25)
					{
						arr[countPatient] = new T();
						arr[countPatient].setHealth(health);
						arr[countPatient].setTime(0);
						allPatient++;
						countPatient++;
					}
					else
					{
						discharge(47,tempCount);
						//countPatient--;
						if (countPatient < 25)
						{
							arr[countPatient] = new T();
							arr[countPatient].setHealth(health);
							arr[countPatient].setTime(0);
							allPatient++;
							countPatient++;
						}
					}
				}
			}
		}
		public void discharge(double health, int patient)
		{
			int count=0;
			double a = arr[0].getHealthRating();
			int t = arr[0].getTime();
			for (int i = 0; i < countPatient; i++)
			{
				if (arr[i].getHealthRating() >= health &&count<=patient)
				{
					count++;
					averageTime += arr[i].getTime();
					dischargePatient++;
					for (int j = i; j < countPatient-1; j++)
					{
						arr[j] = arr[j + 1];
					}
					i = 0;
					countPatient--;
				}
			}
			load.Add(countPatient / 25);
		}
		public void setCountDay(int countDay)
		{
			this.countDay = countDay;
		}

		public void printArr()
		{
			s = "";
			for (int i = 0; i < countPatient; i++)
			{
				s += "Patient " + (i + 1) + " HealthRating: " + Math.Round(arr[i].getHealthRating(), 3) + " Arrival time:" + arr[i].getTime() + "\r\n";
			}
			form.setText(s);
		}

		public void statistic(int k)
		{
			int i = 0;
			double sum = 0;
			for (i = 0; i < load.Count; i++)
				sum += load[i];
			if (k == 1)
			{
				if (dischargePatient != 0)
					form.setStat(allPatient, averageTime / dischargePatient, sum / countDay, dynamic);
				else
					form.setStat(allPatient, 0, sum / countDay, dynamic);
			}
			else
			{
				if (dischargePatient != 0)
					form.setStat(allPatient, averageTime / dischargePatient, sum / countDay, null);
				else
					form.setStat(allPatient, 0, sum / countDay, null);
			}
		}
	}
}
