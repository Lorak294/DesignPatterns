using DesignPatterns.Entities.Engine;
using DesignPatterns.Entities.FuelSystem;
using DesignPatterns.Entities.Vehicles;
using DesignPatterns.Singleton;

namespace DesignPatterns.Visitor
{
    public class DbSaveVisitor : ISaveEntitiyVisitor
    {
        private Database _db = Database.GetInstance();
        public void Visit(IEngine engine)
        {
            _db.SaveEngine(engine);
        }

        public void Visit(IFuelSystem fuelSystem)
        {
            _db.SaveFuelSystem(fuelSystem);
        }

        void ISaveEntitiyVisitor.Visit(IVehicle vehicle)
        {
            _db.SaveVehicle(vehicle);
        }
    }
}
