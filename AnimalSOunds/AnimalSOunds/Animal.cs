using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSOunds
{
    public abstract class Animal
    {
        public abstract string Name { get; }
        public abstract string MakeSound();
    }
}
