using DesignPatterns.Entities.Engine;
using DesignPatterns.Entities.FuelSystem;
using DesignPatterns.Entities.Vehicles;
using System.Linq;

namespace DesignPatterns.Singleton
{
    public class Database
    {
        private static Database? instance;

        private List<IVehicle> vehicles = new List<IVehicle>();

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
            vehicles.Add(vehicle);
        }

        public List<IVehicle> GetVehicles()
        {
            Console.WriteLine("Getting vehicles form the db...");
            return vehicles;
        }

        public List<Car> GetVehiclesOfType<T>()
            where T: IVehicle
        {
            Console.WriteLine("Getting cars form the db...");
            return vehicles.OfType<Car>().ToList();
        }
    }
}
