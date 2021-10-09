using System;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    abstract class HouseDeveloper
    {
        private readonly static Random _random = new();
        protected string Name { get; init; }
        public double Rating => _random.NextDouble() * _random.Next(1, 100);

        public HouseDeveloper(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentOutOfRangeException(nameof(name));
            }

            Name = name;
        }

        public abstract House Build();

    }
}
