using System;
using System.Collections.Generic;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Product<float>("Apple", 100f, 200f);
            var eating = new Eating<Apple>();
            var p2 = new Product<int>("Banana", 90, 135);

            var list = new List<int>();
            var map = new Dictionary<int, string>();
            map.Add(5, "5");
            map.Add(6, "6");
            var apple = new Apple<int>("Red Apple", 100, 200);
            Console.WriteLine(apple);
        }
    }
}
