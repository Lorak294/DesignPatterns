using DesignPatterns.Entities.Engine;
using DesignPatterns.Entities.FuelSystem;

namespace DesignPatterns.Entities.PartFactories
{
    internal interface ICarPartsFactory
    {
        IEngine CreateEngine(int power);
        IFuelSystem CreateFuelSystem(int capacity);
    }
}
