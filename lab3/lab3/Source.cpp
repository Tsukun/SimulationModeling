#include "SpecialPatient.h"
#include "DtPatient.h"
#include "Hospital.h"
#include <iostream>
using namespace std;
int main() 
{
	srand(time(NULL));
	Hospital<SpecialPatient>* hospDt = new Hospital<SpecialPatient>();
	hospDt->printArr();

	return 0;
}