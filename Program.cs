using DesignPatterns.Entities.PartFactories;
using DesignPatterns.Entities.Vehicles;
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
                // save the car using visitor
                c.Save(info.visitor);
            }

        }
    }
}