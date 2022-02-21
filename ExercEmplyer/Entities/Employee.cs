using System;
using System.Collections.Generic;
using System.Text;

namespace ExercEmplyer.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuerPerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuerPerHour)
        {
            Name = name;
            Hours = hours;
            ValuerPerHour = valuerPerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuerPerHour;
        }
    }
}
