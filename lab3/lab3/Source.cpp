#include "SpecialPatient.h"
#include "DtPatient.h"
#include "Hospital.h"
#include <iostream>
#define dayCount 15
using namespace std;
int main() 
{
	srand(time(NULL));
	Hospital<DtPatient>* hospDt = new Hospital<DtPatient>();
	for (int i = 0; i < dayCount; i++)
	{
		hospDt->arravial(1);
		hospDt->discharge(49);
	}
	hospDt->statistic(1);
	Hospital<SpecialPatient>* specHosp = new Hospital<SpecialPatient>();
	specHosp->setCountDay(dayCount);
	for (int i = 0; i < dayCount; i++)
	{
		specHosp->arravial(2);
		specHosp->discharge(49);
	}
	specHosp->statistic(2);
	return 0;
}