using DesignPatterns.Entities.Engine;
using DesignPatterns.Entities.FuelSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Entities.PartFactories
{
    public class ElectricFactory : ICarPartsFactory
    {
        public IEngine CreateEngine(int power) => new ElectricEngine(power);
        public IFuelSystem CreateFuelSystem(int capacity) => new ElectricSystem(capacity);
    }
}
