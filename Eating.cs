using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Eating<T>
        where T : Product 
    {
        public int Volume { get; private set; }
        public void add(T product)
        {
            Volume += product.Volume * product.Energy; 
        }
    }
}
