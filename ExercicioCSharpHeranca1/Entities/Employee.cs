using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCSharpHeranca1.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHours { get; set; }

        public Employee() { }

        public Employee(string name, int hours, double valuePerHours)
        {
            Name = name;
            Hours = hours;
            ValuePerHours = valuePerHours;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHours;
        }

        public override string ToString()
        {
            return $"{Name} - $ {Payment().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
