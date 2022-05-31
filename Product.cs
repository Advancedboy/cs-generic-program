using System;

namespace Generic
{
    internal class Product<T>
    {
        public string Name { get; set; }
        public T Volume { get; set; }
        public T Energy { get; set; }
        public Product(string name, T volume, T energy)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            if(volume == null)
            {
                throw new ArgumentException(nameof(volume));
            }
            if(energy == null)
            {
                throw new ArgumentException(nameof(energy));
            }
            Name = name;
            Volume = volume;
            Energy = energy;
        }
        public override string ToString()
        {
            return $"Name: {Name}.\nVolume: {Volume}.\nEnergy: {Energy}.";
           
        }
    }
}
