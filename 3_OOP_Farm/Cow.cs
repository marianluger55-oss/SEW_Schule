using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _3_OOP_Farm
{
    internal class Cow
    {
        private string name;
        private string breed;
        private int weight;

        public Cow(string name, string breed, int weight)
        {
            this.name = name;
            this.breed = breed;
            this.weight = weight;
        }

        public string MakeNoise()
        {
            return "Muuuuh....";
        }

        public string GetInfo()
        {
            return $"Name: {this.name}, Rasse: {this.breed}, Gewicht: {this.weight}";
        }

        public int GetWeight()
        {
            return this.weight;
        }
    }

}
