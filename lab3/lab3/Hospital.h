#pragma once
#include "Patient.h"
#include "DtPatient.h"
#include "SpecialPatient.h"
template <class T>
class Hospital
{
public:
	Hospital();
	void discharge();
	void arravial();
	void stat();
	void printArr();
private:
	T* arr;
	int countPatient;
	int countDay;
};

template <class T>
Hospital<T>::Hospital() 
{
	srand(time(NULL));
	countPatient = 18;
	arr = new T[25];
	for (int i = 0; i < countPatient;i++) 
	{
		arr[i].setHealth(30+rand()%10);
		arr[i].setTime(0);
	}	
}
template <class T>
void Hospital<T>::arravial() 
{
			if (T = DtPatient)
			{
				for (int i = 0; i < 2 ; i++)
				{
					arr[countPatient].setHealth(20);
					arr[countPatient].setTime(0);
					countPatient++;
				}
			}
		
			if (T = SpecialPatient)
			{
				arr[i].setHealth(rand() % 44);
				arr[i].setTime(0);
			}
}
template <class T>
void Hospital<T>::printArr()
{
	for (int i = 0; i < countPatient; i++) 
	{
		cout <<"Patient "<<i<<" HealthRating:"<<arr[i].getHealthRating() << " Arrival time:" << arr[i].getTime() << endl;
	}
}