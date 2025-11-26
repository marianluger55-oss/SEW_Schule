using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Dog : Animal
    {
        public string Breed { get; set; }

        public void Bark()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }
}
