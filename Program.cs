using DesignPatterns.Entities.PartFactories;
using DesignPatterns.Entities.Vehicles;
using DesignPatterns.Proxy.CarServices;
using DesignPatterns.Singleton;
using DesignPatterns.Visitor;
using System;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main()
        {
            DbSaveVisitor dbVisitor = new DbSaveVisitor();
            FileSaveVisitor fileVisitor = new FileSaveVisitor();

            var carInitInfo = new (ICarPartsFactory factory, string brand, string model, int engPower, int fuelCap, int startFuel, ISaveEntitiyVisitor visitor)[]{
                (new DieselFactory(), "Volkswagen","Golf",100,40,40, dbVisitor),
                (new PetrolFactory(), "Fiat","Multipla",75,30,0, dbVisitor),
                (new ElectricFactory(), "Tesla","Model S",600,150,130, fileVisitor),
                (new PetrolFactory(), "Daewoo","Tico Fantastico",1000,100,90, dbVisitor),
            };

            foreach (var info in carInitInfo)
            {
                Console.WriteLine("=====================================================================");
                // build the car (builder + abstract factory)
                Car c = new CarBuilder()
                    .AddBrand(info.brand)
                    .AddModel(info.model)
                    .AddEngine(info.factory.CreateEngine(info.engPower))
                    .AddFuelSystem(info.factory.CreateFuelSystem(info.fuelCap))
                    .Build();
                // print car info
                Console.WriteLine($"Created {c.GetInfo()}");
                // start the car
                c.RefuelAndGo(info.startFuel);
                // save the car using visitor (single db connection because of singleton pattern)
                c.Save(info.visitor);
            }

            // get cars from the db using service directy (no cache)
            Console.WriteLine("=====================================================================");
            Console.WriteLine("GETTING CARS FROM THE DB USING SERVICE:");
            ICarQueryService carQueryService = new CarQueryService();
            var cars = carQueryService.GetCars(CarQueryCriteria.Any());
            Console.WriteLine("RETREIVED CARS:");
            foreach (var c in cars)
            {
                Console.WriteLine($"{c.GetInfo()}");
            }
            cars = carQueryService.GetCars(CarQueryCriteria.Any());
            Console.WriteLine("RETREIVED CARS:");
            foreach (var c in cars)
            {
                Console.WriteLine($"{c.GetInfo()}");
            }

            // get cars from the db using service proxy (cached results)
            Console.WriteLine("=====================================================================");
            Console.WriteLine("GETTING CARS FROM THE DB USING SERVICE:");
            carQueryService = new CarQueryServiceProxy(carQueryService);
            cars = carQueryService.GetCars(CarQueryCriteria.Any());
            Console.WriteLine("RETREIVED CARS:");
            foreach (var c in cars)
            {
                Console.WriteLine($"{c.GetInfo()}");
            }
            cars = carQueryService.GetCars(CarQueryCriteria.Any());
            Console.WriteLine("RETREIVED CARS:");
            foreach (var c in cars)
            {
                Console.WriteLine($"{c.GetInfo()}");
            }
        }
    }
}