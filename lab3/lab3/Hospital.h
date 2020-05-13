#pragma once
#include "Patient.h"
#include "DtPatient.h"
#include "SpecialPatient.h"
#include <cmath>
#include "vector"
template <class T>
class Hospital
{
public:
	Hospital();
	void discharge(double health);
	void arravial(int k);
	void statistic(int k);
	void printArr();
	void setCountDay(int countDay);
private:
	T* arr;
	vector <double> load;
	vector <double> dynamic;
	int averageTime;
	int countPatient;
	int allPatient;
	int countDay;
	int dischargePatient;
};

template <class T>
Hospital<T>::Hospital() 
{
	averageTime = 0;
	dischargePatient = 0;
	srand(time(NULL));
	countPatient = 18;
	allPatient = 18;
	countDay = 1;
	arr = new T[25];
	for (int i = 0; i < countPatient;i++) 
	{
		arr[i].setHealth(30+rand()%10);
	}	
}

double NormRandom(double Mx, double Sigma)
{
	double  a, b, r, Sq;
	do
	{
		a = 2.0 * rand() / RAND_MAX - 1.0;
		b = 2.0 * rand() / RAND_MAX - 1.0;
		r = a * a + b * b;
	} while (r >= 1);
	Sq = sqrt(-2.0 * log(r) / r);
	return Mx + Sigma * a * Sq;
}

template <class T>
void Hospital<T>::arravial(int k) 
{
				for(int i=0;i<countPatient;i++)
				{
					arr[i].healthUp();
				}
			if (k == 1 )
			{
				for (int i = 0; i < 2; i++)
				{
					if (countPatient != 25)
					{
						arr[countPatient ].setHealth(20);
						arr[countPatient ].setTime(0);
						countPatient++;
						allPatient++; 
					}
					else 
					{
						discharge(47);
						if (countPatient != 25)
						{
							arr[countPatient].setHealth(20);
							arr[countPatient].setTime(0);
							countPatient++;
							allPatient++;
						}

					}

				}
					//cout  << "Arravial"<<endl;
					//printArr();
			}
		
			if (k==2)
			{
				int tempCount = (int)floor(NormRandom(2, 1) + 0.5);
				for (int i = 0; i < tempCount; i++) 
				{
					int health = rand() % 44;
					if (countPatient < 25)
					{
						arr[countPatient].setHealth(health);
						arr[countPatient].setTime(0);
						allPatient++;
						countPatient++;
					}
					else
					{
						discharge(47);
						countPatient--;
						if (countPatient < 25)
						{
							arr[countPatient].setHealth(health);
							arr[countPatient].setTime(0);
							allPatient++;
							countPatient++;
						}
					}
				}
			}
			cout  << "Arravial"<<endl;
			printArr();
}
template <class T>
void Hospital<T>::discharge(double health)
{
	for (int i = 0; i < countPatient;i++) 
	{
		if (arr[i].getHealthRating() >= health) 
		{
			averageTime += arr[i].getTime();
			dischargePatient++;
			for (int j = i; j < countPatient; j++) 
			{
				arr[j] = arr[j + 1];
			}
			i = 0;
			countPatient--;
		}
	}
	load.push_back(countPatient/25);
	dynamic.push_back(countPatient);
	/*cout  << "  Discharge"<<endl;
	printArr();*/
}

template<class T>
inline void Hospital<T>::setCountDay(int countDay)
{
	this->countDay = countDay;
}

template<class T>
void Hospital<T>::statistic(int k)
{
	int i = 0;
	double sum = 0;
	for (i = 0; i < load.size(); i++)
		sum += load.at(i);
	cout << "All patient =" << allPatient << endl;
	if (dischargePatient != 0)
		cout << "Average time = " << averageTime / dischargePatient << endl;
	else cout << "nobody discharged" << endl;
		cout<< "Average load = " << sum / countDay << endl;
	if (k == 1)
		for (i = 0; i < dynamic.size(); i++)
			cout << "Day " << i + 1 << " Dynamic = " << dynamic.at(i)<<endl;
}

template <class T>
void Hospital<T>::printArr()
{
	for (int i = 0; i < countPatient; i++) 
	{
		cout <<"Patient "<<i+1<<" HealthRating:"<<arr[i].getHealthRating() << " Arrival time:" << arr[i].getTime() << endl;
	}
}


