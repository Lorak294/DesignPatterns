using DesignPatterns.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.CarServices
{
    public class CarQueryServiceProxy : ICarQueryService
    {
        private readonly ICarQueryService _carQueryService;
        private IEnumerable<Car> _cached_cars;

        public CarQueryServiceProxy(ICarQueryService carQueryService)
        {
            _carQueryService = carQueryService;
        }

        public IEnumerable<Car> GetCars(CarQueryCriteria criteria)
        {
            if(_cached_cars == null)
                _cached_cars = _carQueryService.GetCars(criteria);

            return _cached_cars.Where(c =>
                c.Engine.Power >= criteria.EnginePower.min &&
                c.Engine.Power <= criteria.EnginePower.max &&
                c.FuelSystem.Capacity >= criteria.FuelCapacity.min &&
                c.FuelSystem.Capacity <= criteria.FuelCapacity.max &&
                criteria.EngineTypes.Contains(CarQueryCriteria.TypeFromInstance(c))
            );
        }
    }
}
