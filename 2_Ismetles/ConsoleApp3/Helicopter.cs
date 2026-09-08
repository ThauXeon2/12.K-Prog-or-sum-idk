using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Helicopter : AirVehicle
    {
        private int RotorCount {  get; set; }
        private bool IsRescueHelicopter {  get; set; }
        public Helicopter(string name, int builtYear, int maxSpeed, int maxAltitude, int rotorCount, bool isRescueHelicopter) : base(name, builtYear, maxSpeed, maxAltitude)
        {
            RotorCount = rotorCount;
            IsRescueHelicopter = isRescueHelicopter;
        }
        public bool IsSuitableForRescue() => IsRescueHelicopter;
        public string GetRotorInfo() => $"A helikopter {RotorCount} rotorral rendelkezik.";
        public override string GetVehicleInfo()
        {
            string ans = IsRescueHelicopter ? "igen" : "Nem";
            return $"A repülő neve: {Name}, Gyártási éve: {GetBuiltYear()}, Maximális sebessége: {MaxSpeed}km/h, Rotorok száma: {RotorCount}db, Mentőhelikopter?: {ans}";
        }
    }
}
