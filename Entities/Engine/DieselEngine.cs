using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Entities.Engine
{
    public class DieselEngine : IEngine
    {
        public int Power { get; set; }

        public DieselEngine(int power)
        {
            Power = power;
        }

        public void MakeSound()
        {
            Console.WriteLine("Pyr Pyr Pyr!");
        }
    }
}
