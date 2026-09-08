using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class AirVehicle : Vehicle
    {
        protected int MaxSpeed { get; set; }
        private int MaxAltitude { get; set; }
        public AirVehicle(string name, int builtYear, int maxSpeed, int maxAltitude) : base(name,builtYear)
        {
            MaxSpeed = maxSpeed;
            MaxAltitude = maxAltitude;
        }
        public int GetMaxAltitude() => MaxAltitude;
        public bool IsFasterThan(int speed) => MaxSpeed > speed;
    }
}
