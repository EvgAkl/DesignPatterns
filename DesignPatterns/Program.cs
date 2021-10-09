using System;
using DesignPatterns.CreationalPatterns.FactoryMethod;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var e1 = new WoodHouse(1);
            var e2 = new PanelHouse(2);
            var e3 = new BrickHouse(3);
        }
    }
}
