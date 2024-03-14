using DesignPatterns.Entities.Engine;
using DesignPatterns.Entities.FuelSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Entities.Vehicles
{
    public class Car : IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public IEngine Engine { get; set; }
        public IFuelSystem FuelSystem { get; set; }

        public void RefuelAndGo(int fuel)
        {
            FuelSystem.AddFuel(fuel);
            Engine.MakeSound();
        }

        public void PrintInfo()
        {
            Console.WriteLine($"[{Brand} {Model} with {Engine.Power} HP engine]");
        }
    }
}
