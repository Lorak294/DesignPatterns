
using DesignPatterns.Entities.Engine;
using DesignPatterns.Entities.Vehicles;

namespace DesignPatterns.Proxy.CarServices
{
    public class CarQueryCriteria
    {
        public enum EngineType
        {
            Petrol,
            Diesel,
            Electric,
        }

        public (int min, int max) EnginePower { get; set; }
        public (int min, int max) FuelCapacity { get; set; }
        public HashSet<EngineType> EngineTypes { get; set; }

        public CarQueryCriteria()
        {
            EnginePower = (int.MinValue, int.MaxValue);
            FuelCapacity = (int.MinValue, int.MaxValue);
            EngineTypes = new HashSet<EngineType>();   
        }

        public static CarQueryCriteria Any()
        {
            CarQueryCriteria criteria = new CarQueryCriteria();
            criteria.EnginePower = (int.MinValue, int.MaxValue);
            criteria.FuelCapacity = (int.MinValue, int.MaxValue);
            criteria.EngineTypes.Add(EngineType.Petrol);
            criteria.EngineTypes.Add(EngineType.Diesel);
            criteria.EngineTypes.Add(EngineType.Electric);
            return criteria;
        }

        public void SetPower(int power)
        {
            EnginePower = (power, power);
        }        
        public void SetPower(int min_power, int max_power)
        {
            EnginePower = (min_power, max_power);
        }
        public void SetFuelCapacity(int fuel_cap)
        {
            FuelCapacity = (fuel_cap, fuel_cap);
        }
        public void SetFuelCapacity(int min_fuel_cap, int max_fuel_cap)
        {
            FuelCapacity = (min_fuel_cap, max_fuel_cap);
        }

        public static EngineType TypeFromInstance(Car car)
        {
            return car.Engine switch
            {
                ElectricEngine => EngineType.Electric,
                PetrolEngine => EngineType.Petrol,
                DieselEngine => EngineType.Diesel,
                _ => throw new Exception("unrecognized engine type"),
            };
        }
    }
}
