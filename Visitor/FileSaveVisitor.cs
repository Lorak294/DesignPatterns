using DesignPatterns.Entities.Engine;
using DesignPatterns.Entities.FuelSystem;
using DesignPatterns.Entities.Vehicles;

namespace DesignPatterns.Visitor
{
    public class FileSaveVisitor : ISaveEntitiyVisitor
    {
        public void Visit(IEngine engine)
        {
            Console.WriteLine($"Saving [TYPE: {engine.GetType()} - POWER: {engine.Power}] to the file...");
        }

        public void Visit(IFuelSystem fuelSystem)
        {
            Console.WriteLine($"Saving [TYPE: {fuelSystem.GetType()} - CAPACITY: {fuelSystem.Capacity}] to the file...");
        }

        void ISaveEntitiyVisitor.Visit(IVehicle vehicle)
        {
            Console.WriteLine($"Saving {vehicle.GetInfo()} to the file...");
        }
    }
}
