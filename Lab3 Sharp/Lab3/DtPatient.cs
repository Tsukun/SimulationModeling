using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	class DtPatient : Patient
	{
		double HealthRating;
		int t;
		public DtPatient()
		{
			HealthRating = 20;
			t = 0;
		}
		public override double getHealthRating() { return HealthRating; }
		public override int getTime() { return t; }
		//DtPatient(const DtPatient& patient);
		//DtPatient& operator=(const DtPatient& patient);
		public override void healthUp()
		{
			this.HealthRating += 2;
			this.t++;
		}
	}
}
