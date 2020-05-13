#pragma once
#include "Patient.h"
#include <time.h>
#include <iostream>
using namespace std;
class DtPatient :public Patient
{
public:
	DtPatient();
	DtPatient(const DtPatient& patient);
	DtPatient& operator=(const DtPatient& patient);
	void healthUp();
	void setHealth(int HealthRating) { this->HealthRating = HealthRating; };
	void setTime(int t) { this->t=t; };
	int getTime() { return t; };
	double getHealthRating() { return HealthRating; };
private:
	double HealthRating;
	int t;
};

DtPatient::DtPatient()
{
	HealthRating = 20;
	t = 0;
}
DtPatient::DtPatient(const DtPatient& patient)
{
	this->HealthRating = patient.HealthRating;
	this->t = patient.t;
}
DtPatient& DtPatient::operator=(const DtPatient& patient)
{
	this->HealthRating = patient.HealthRating;
	this->t = patient.t;
	return *this;
}
void DtPatient::healthUp()
{
		HealthRating +=2;
		t++;

}
