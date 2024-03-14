using DesignPatterns.Builder;
using DesignPatterns.Entities.Engine;
using DesignPatterns.Entities.FuelSystem;

namespace DesignPatterns.Entities.Vehicles
{
    public class CarBuilder : FunctionalBuilder<Car, CarBuilder>
    {
        public CarBuilder AddModel(string model) => Do(c => c.Model = model);
        public CarBuilder AddBrand(string brand) => Do(c => c.Brand = brand);
        public CarBuilder AddEngine(IEngine engine) => Do(c => c.Engine = engine);
        public CarBuilder AddFuelSystem(IFuelSystem fuelSystem) => Do(c => c.FuelSystem = fuelSystem);
    }
}
