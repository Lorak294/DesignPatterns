using DesignPatterns.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Entities.FuelSystem
{
    public interface IFuelSystem
    {
        int Capacity { get; set; }
        void AddFuel(int amount);
        void Save(ISaveEntitiyVisitor visitor) { visitor.Visit(this); }
    }
}
