#include "SpecialPatient.h"
#include "DtPatient.h"
#include "Hospital.h"
#include <iostream>
using namespace std;
int main() 
{
	srand(time(NULL));
	Hospital<DtPatient>* hospDt = new Hospital<DtPatient>();
	for (int i = 0; i < 10; i++)
	{
		hospDt->arravial(1);
		hospDt->discharge(49);
	}
		

	return 0;
}