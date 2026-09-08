using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Airplane : AirVehicle
    {
        protected int Capacity {  get; set; }
        private int FuelAmount { get; set; }
        public Airplane(string name, int builtYear, int maxSpeed, int maxAltitude, int capacity, int fuelAmount) : base(name, builtYear, maxSpeed, maxAltitude)
        {
            Capacity = capacity;
            FuelAmount = fuelAmount;
        }
        public int GetFuelAmount() => FuelAmount;
        public void Refuel(int amount)
        {
            if (amount <= 0)
                return;
            else { FuelAmount += amount; }
        }
        public bool ConsumeFuel(int amount)
        {
            if (FuelAmount - amount >= 0)
                {
                    FuelAmount -= amount;
                    return true;
                }
            else {  return false; }
        }
        public bool HasLargeCapacity(int limit) => FuelAmount>=limit;
    }
}
