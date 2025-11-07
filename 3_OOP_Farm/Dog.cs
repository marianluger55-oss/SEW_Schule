using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_OOP_Farm
{
    internal class Dog
    {
        private string name;

        public Dog(string name)
        {
            this.name = name;
        }

        public string MakeNoise()
        {
            return "Wufff...";
        }

        public string GetInfo()
        {
            return $"Name: {this.name}";
        }
    }
}
