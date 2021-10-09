using System;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    class PanelHouse : House
    {
        public PanelHouse(int houseNamber) : base(houseNamber, 2.7)
        {
            HouseType = HouseType.Panel;
            Console.WriteLine($"{base.GetHouseType()} house with number {base.HouseNamber} was build");
        }
    }
}
