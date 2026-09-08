using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class PassengerPlane : Airplane
    {
        private int BusinessSeats {  get; set; }
        private int TicketPrice { get; set; }
        public PassengerPlane(string name, int builtYear, int maxSpeed, int maxAltitude, int capacity, int fuelAmount, int businessSeats, int ticketPrice) : base(name, builtYear, maxSpeed, maxAltitude, capacity, fuelAmount)
        {
            BusinessSeats = businessSeats;
            TicketPrice = ticketPrice;
        }
        public int GetTicketPrice() => TicketPrice;
        public int CalculateRevenue(int soldTickets) => TicketPrice * soldTickets;
        public double GetBusinessSeatPercentage() => Capacity / BusinessSeats;
        public override string GetVehicleInfo() => $"A repülő neve: {Name}, Gyártási éve: {GetBuiltYear()}, Maximális sebessége: {MaxSpeed}km/h, Kapacitása: {Capacity}L, Jegyár: {TicketPrice}FT";
    }
}
