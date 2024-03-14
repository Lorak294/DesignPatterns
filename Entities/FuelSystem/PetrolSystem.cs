using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Entities.FuelSystem
{
    public class PetrolSystem : IFuelSystem
    {
        public int Capacity { get; set; }

        public PetrolSystem(int capacity)
        {
            Capacity = capacity;
        }

        public void AddFuel(int amount)
        {
            string full_info = amount >= Capacity ? " - TANK FULL" : string.Empty;
            Console.WriteLine($"Added {amount} L of petrol to the tank {full_info}");
        }
    }
}
