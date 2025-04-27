using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSOunds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Dog(),
                new Cat(),
                new Cow()
            };

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Name} makes sound: {animal.MakeSound()}");
            }
        }
    }
}
