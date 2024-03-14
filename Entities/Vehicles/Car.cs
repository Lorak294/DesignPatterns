using DesignPatterns.Entities.Engine;
using DesignPatterns.Entities.FuelSystem;
using DesignPatterns.Visitor;
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
            Console.WriteLine("Refuelling....");
            FuelSystem.AddFuel(fuel);
            Console.WriteLine("Starting....");
            if(fuel > 0)
                Engine.MakeSound();
            else
                Console.WriteLine("Out of fuel :(");
        }

        public string GetInfo()
        {
            var engine_type_str = Engine.GetType().Name;
            engine_type_str = engine_type_str.Substring(0, engine_type_str.LastIndexOf("Engine"));
            return $"[{Brand} {Model} with {Engine.Power} HP {engine_type_str} engine]";
        }

        public void Save(ISaveEntitiyVisitor visitor) 
        {
            Engine.Save(visitor);
            FuelSystem?.Save(visitor);
            visitor.Visit(this); 
        }
    }
}
