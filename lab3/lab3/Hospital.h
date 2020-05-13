#pragma once
#include "Patient.h"
#include "DtPatient.h"
#include "SpecialPatient.h"
#include <cmath>
template <class T>
class Hospital
{
public:
	Hospital();
	void discharge(double health);
	void arravial(int k);
	void statistic();
	void printArr();
	void setCountDay(int countDay);
private:
	T* arr;
	int countPatient;
	int allPatient;
	int countDay;
};

template <class T>
Hospital<T>::Hospital() 
{
	srand(time(NULL));
	countPatient = 18;
	allPatient = 0;
	countDay = 1;
	arr = new T[25];
	for (int i = 0; i < countPatient;i++) 
	{
		arr[i].setHealth(30+rand()%10);
	}	
}
template <class T>
void Hospital<T>::arravial(int k) 
{
			if (k == 1 )
			{
				for(int i=0;i<countPatient;i++)
				{
					arr[i].healthUp();
				}
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
					cout  << "Arravial"<<endl;
					printArr();
			}
		
			if (k==2)
			{
				double lyambda = 2 ; // 2 пациента за сутки
				double t = 0;
				int tempCount = 0;
				while (t <=1) 
				{
					double tau = -1 / (lyambda * log(rand()));
					t += tau;
					tempCount++;
				}
				allPatient += tempCount;
				for (int i = 0; i < tempCount; i++) 
				{
					int health = rand() % 44;
					if (countPatient == 25 && health > 41)
					{
						tempCount --;
						break;
					}
					arr[countPatient + i].setHealth(health);
					arr[countPatient + i].setTime(0);

				}
				countPatient += tempCount;
			}
}
template <class T>
void Hospital<T>::discharge(double health)
{
	for (int i = 0; i < countPatient;i++) 
	{
		if (arr[i].getHealthRating() >= health) 
		{
			for (int j = i; j < countPatient; j++) 
			{
				arr[j] = arr[j + 1];
			}
			i = 0;
			countPatient--;
		}
	}
	//cout  << "  Discharge"<<endl;
	//printArr();
}

template<class T>
inline void Hospital<T>::setCountDay(int countDay)
{
	this.countDay = countDay;
}

template<class T>
void Hospital<T>::statistic()
{
	cout << "All patient =" << allPatient << endl
		<< "Count Day = " << countDay << endl;
}

template <class T>
void Hospital<T>::printArr()
{
	for (int i = 0; i < countPatient; i++) 
	{
		cout <<"Patient "<<i+1<<" HealthRating:"<<arr[i].getHealthRating() << " Arrival time:" << arr[i].getTime() << endl;
	}
}


