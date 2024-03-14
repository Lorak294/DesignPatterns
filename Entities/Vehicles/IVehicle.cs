using DesignPatterns.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Entities.Vehicles
{
    public interface IVehicle
    {
        void RefuelAndGo(int fuel);
        string GetInfo();
        void Save(ISaveEntitiyVisitor visitor) { visitor.Visit(this); }
    }
}
