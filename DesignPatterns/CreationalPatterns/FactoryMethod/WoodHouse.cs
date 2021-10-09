using System;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    class WoodHouse : House
    {

        public WoodHouse(int houseNamber) : base(houseNamber, 1.5)
        {
            HouseType = HouseType.Wood;
            Console.WriteLine($"{base.GetHouseType()} house with number {base.HouseNamber} was build");
        }

    }
}
