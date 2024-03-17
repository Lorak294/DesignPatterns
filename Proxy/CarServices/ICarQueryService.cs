using DesignPatterns.Entities.Vehicles;

namespace DesignPatterns.Proxy.CarServices
{
    public interface ICarQueryService
    {
        public IEnumerable<Car> GetCars(CarQueryCriteria criteria);
    }
}
