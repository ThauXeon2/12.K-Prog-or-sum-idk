using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Vehicle
    {
        protected string Name { get; set; }
        private int BuiltYear { get; set; }
        public Vehicle(string name, int builtYear)
        {
            Name = name;
            BuiltYear = builtYear;
        }
        public int GetBuiltYear() => BuiltYear;
        public int GetAge(int currentYear) => currentYear - BuiltYear;
        public virtual string GetVehicleInfo() => $"A jármű neve: {Name}, Gyártási éve: {BuiltYear}";
    }
}
