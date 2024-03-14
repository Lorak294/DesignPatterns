using DesignPatterns.Entities.Engine;
using DesignPatterns.Entities.FuelSystem;
using DesignPatterns.Entities.Vehicles;
using DesignPatterns.Singleton;

namespace DesignPatterns.Visitor
{
    public class DbSaveVisitor : ISaveEntitiyVisitor
    {
        public void Visit(IEngine engine)
        {
            Database.GetInstance().SaveEngine(engine);
        }

        public void Visit(IFuelSystem fuelSystem)
        {
            Database.GetInstance().SaveFuelSystem(fuelSystem);
        }

        void ISaveEntitiyVisitor.Visit(IVehicle vehicle)
        {
            Database.GetInstance().SaveVehicle(vehicle);
        }
    }
}
