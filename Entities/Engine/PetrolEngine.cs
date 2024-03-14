using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Entities.Engine
{
    public class PetrolEngine : IEngine
    {
        public int Power { get; set; }

        public PetrolEngine(int power)
        {
            Power = power;
        }

        public void MakeSound()
        {
            Console.WriteLine("Wroooom!");
        }
    }
}
