using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab3
{
    class SpecialPatient : Patient
    {
        int t = 0;
        double HealthRating = 0;
        public override int getTime() { return t; }
        public override double getHealthRating() { return HealthRating; }
        public override void setHealth(double HealthRating) { this.HealthRating = HealthRating; }
        public override void healthUp()
        {
            Random a = new Random();
            //Thread.Sleep(10);
            HealthRating += 0.2 + a.NextDouble();
            t++;
        }
    }
}
