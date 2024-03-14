using DesignPatterns.Entities.Engine;
using DesignPatterns.Entities.FuelSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Entities.PartFactories
{
    public class PetrolFactory : ICarPartsFactory
    {
        public IEngine CreateEngine(int power) => new PetrolEngine(power);
        public IFuelSystem CreateFuelSystem(int capacity) => new PetrolSystem(capacity);
    }
}
