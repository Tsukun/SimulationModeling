#pragma once
#include "Patient.h"
#include <time.h>
#include <iostream>
using namespace std;

class SpecialPatient:public Patient
{
public:
	SpecialPatient();
	SpecialPatient(const SpecialPatient &patient);
	SpecialPatient& operator=(const SpecialPatient& patient);
	void healthUp();
	void setHealth(int HealthRating) { this->HealthRating = HealthRating; };
	void setTime(int t) { this->t = t; };
	int getTime() { return t; };
	double getHealthRating() { return HealthRating; };
private:
	double HealthRating;
	int t;
};
SpecialPatient::SpecialPatient() 
{	
	HealthRating = rand() % 44;
	t = 0;
}
SpecialPatient::SpecialPatient(const SpecialPatient& patient)
{
	this->HealthRating = patient.HealthRating;
	this->t = patient.t;
}
SpecialPatient& SpecialPatient::operator=(const SpecialPatient& patient)
{
	this->HealthRating = patient.HealthRating;
	this->t = patient.t;
	return *this;
}
void SpecialPatient::healthUp() 
{
	double a;
	a = (rand() / double(RAND_MAX));
		HealthRating +=0.2+a;
		t++;
}
