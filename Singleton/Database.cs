using DesignPatterns.Entities.Engine;
using DesignPatterns.Entities.FuelSystem;
using DesignPatterns.Entities.Vehicles;

namespace DesignPatterns.Singleton
{
    public class Database
    {
        private static Database? instance;

        private Database() 
        {
            Console.WriteLine("[SYSTEM] Conecting to the database server...");
            Console.WriteLine("[SYSTEM] Conected.");
        }

        public static Database GetInstance()
        {
            if(instance == null)
                instance = new Database();
            return instance;
        }

        public void SaveEngine(IEngine engine)
        {
            Console.WriteLine($"Saving [TYPE: {engine.GetType().Name} - POWER: {engine.Power}] to the database...");
        }

        public void SaveFuelSystem(IFuelSystem fuel_system)
        {
            Console.WriteLine($"Saving [TYPE: {fuel_system.GetType().Name} - CAPACITY: {fuel_system.Capacity}] to the database...");
        }

        public void SaveVehicle(IVehicle vehicle)
        {
            Console.WriteLine($"Saving {vehicle.GetInfo()} to the database...");
        }
    }
}
