using DesignPatterns.Entities.Engine;
using DesignPatterns.Entities.FuelSystem;
using DesignPatterns.Entities.Vehicles;

namespace DesignPatterns.Visitor
{
    public interface ISaveEntitiyVisitor
    {
        void Visit(IVehicle vehicle);
        void Visit(IEngine engine);
        void Visit(IFuelSystem fuelSystem);
    }
}
