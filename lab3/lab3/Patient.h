#pragma once
#pragma once
#include <time.h>
#include <iostream>
using namespace std;
class Patient
{
public:
	Patient();
	Patient(const Patient& patient);
	Patient& operator=(const Patient& patient);
	virtual void healthUp() {};
	virtual void setHealth(int HealthRating){this->HealthRating = HealthRating;};
	virtual void setTime(int t) { this->t = t; }
	virtual int getTime() { return t; };
	virtual double getHealthRating() { return HealthRating; };
private:
	double HealthRating;
	int t;
};
Patient::Patient()
{
	HealthRating = 0;
	t = 0;
}

Patient::Patient(const Patient& patient)
{
	this->HealthRating = patient.HealthRating;
	this->t = patient.t;
}

Patient& Patient::operator=(const Patient& patient)
{
	this->HealthRating = patient.HealthRating;
	this->t = patient.t;
	return *this;
}