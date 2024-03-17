using DesignPatterns.Entities.Vehicles;
using DesignPatterns.Singleton;

namespace DesignPatterns.Proxy.CarServices
{
    public class CarQueryService : ICarQueryService
    {
        public IEnumerable<Car> GetCars(CarQueryCriteria criteria)
        {
            var cars = Database.GetInstance().GetVehiclesOfType<Car>();

            return cars.Where(c =>
                c.Engine.Power >= criteria.EnginePower.min &&
                c.Engine.Power <= criteria.EnginePower.max &&
                c.FuelSystem.Capacity >= criteria.FuelCapacity.min &&
                c.FuelSystem.Capacity <= criteria.FuelCapacity.max &&
                criteria.EngineTypes.Contains(CarQueryCriteria.TypeFromInstance(c))
            );
        }
    }
}
