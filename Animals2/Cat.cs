using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals2
{
    class Cat : Animal
    {   

       
        public string Name { get; set; }


        public void Meow()
        {
            Console.WriteLine("Meow! Meow!");
        }
    }
}
