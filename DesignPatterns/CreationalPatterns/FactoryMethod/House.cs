using System;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    abstract class House
    {
        private const int BASE_GUARANTEE_PERIOD = 60;
        private readonly double _guaranteeСoefficient;
        private readonly int _houseNamber;

        protected HouseType HouseType { get; init; }

        public House(int houseNamber, double guaranteeСoefficient)
        {
            if (houseNamber <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(houseNamber));
            }

            if (double.IsNegative(guaranteeСoefficient))
            {
                throw new ArgumentOutOfRangeException(nameof(guaranteeСoefficient));
            }

            _houseNamber = houseNamber;
            _guaranteeСoefficient = guaranteeСoefficient;
        }

        private void ValidHouseType()
        {
            if (HouseType == HouseType.None)
            {
                throw new InvalidOperationException($"property '{nameof(HouseType)}' has invalid value");
            }
        }
        private string GetHouseTypeName()
        {
            string result = HouseType switch
            {
                HouseType.Wood => "wood",
                HouseType.Panel => "panel",
                HouseType.Brick => "brick",
                _ => throw new ArgumentOutOfRangeException(nameof(HouseType)),
            };
            return result;
        }

        public string GetHouseType()
        {
            ValidHouseType();
            return GetHouseTypeName();
        }
        public string GuaranteePeriod => $"{BASE_GUARANTEE_PERIOD * _guaranteeСoefficient} mounth";
        public int HouseNamber => _houseNamber;
    }
}
