using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Apple<T> : Product<T>
    {
        public Apple(string name, T volume, T energy) : base(name, volume, energy)
        {

        }
    }
}
