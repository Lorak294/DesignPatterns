using DesignPatterns.Singleton;
using System;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main()
        {
            SingletonDemo();

        }

        static void SingletonDemo()
        {
            Database db = Database.GetInstance();
            Database db2 = Database.GetInstance();
        }
    }
}