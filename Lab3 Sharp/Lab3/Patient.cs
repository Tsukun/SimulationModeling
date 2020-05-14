using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Patient
    {
        int t;
        double HealthRating;
        virtual public void setHealth(double HealthRating) { this.HealthRating = HealthRating; }
        virtual public void setTime(int t) { this.t = t; }
        virtual public int getTime() { return t; }
        virtual public double getHealthRating() { return HealthRating; }
        virtual public void healthUp() 
        {
            HealthRating += 2;
            t++;
        }
        public Patient()
        {
            t = 0;
            HealthRating = 0;
        }
    }
}
