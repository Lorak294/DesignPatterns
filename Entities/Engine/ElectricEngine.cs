using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Entities.Engine
{
    public class ElectricEngine : IEngine
    {
        public int Power { get; set; }

        public ElectricEngine(int power)
        {
            Power = power;
        }

        public void MakeSound()
        {
            Console.WriteLine("Bzzzzzzzzz!");
        }
    }
}
