using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Entities.FuelSystem
{
    public class DieselSystem: IFuelSystem
    {
        public int Capacity { get; set; }
        public DieselSystem(int capacity)
        {
            Capacity = capacity;
        }

        public void AddFuel(int amount)
        {
            string full_info = amount >= Capacity ? " - TANK FULL" : string.Empty;
            Console.WriteLine($"Added {amount} L of oil to the tank {full_info}");
        }
    }
}
