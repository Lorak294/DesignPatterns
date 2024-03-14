using DesignPatterns.Entities.PartFactories;
using DesignPatterns.Entities.Vehicles;
using DesignPatterns.Singleton;
using System;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main()
        {
            //SingletonDemo();
            FactoryAndBuilderDemo();


        }

        static void SingletonDemo()
        {
            for(int i=0; i< 10; i++)
            {
                Console.WriteLine($"Creating db instance #{i}");
                Database db = Database.GetInstance();
            }

        }

        static void FactoryAndBuilderDemo()
        {
            var carInitInfo = new(ICarPartsFactory factory,string brand, string model, int engPower, int fuelCap, int startFuel)[]{
                (new DieselFactory(), "Volkswagen","Golf",100,40,40),
                (new PetrolFactory(), "Fiat","Multipla",75,30,25),
                (new ElectricFactory(), "Tesla","Model S",600,150,130),
            };


            foreach (var info in carInitInfo)
            {
                Car c = new CarBuilder()
                    .AddBrand(info.brand)
                    .AddModel(info.model)
                    .AddEngine(info.factory.CreateEngine(info.engPower))
                    .AddFuelSystem(info.factory.CreateFuelSystem(info.fuelCap))
                    .Build();

                c.PrintInfo();

                c.RefuelAndGo(info.startFuel);
            }


        }
    }
}