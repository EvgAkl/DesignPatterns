using System;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    class BrickHouse : House
    {
        public BrickHouse(int houseNamber) : base(houseNamber, 3.5)
        {
            HouseType = HouseType.Brick;
            Console.WriteLine($"{base.GetHouseType()} house with number {base.HouseNamber} was build");
        }
    }
}
