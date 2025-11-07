using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_OOP_Properties
{
    internal class Person
    {
        private string name;

        // Langform
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;      // automatisch erzeugte Parameter, der immer value heißt
            }
        }

        public Person(string name)
        {
            this.name = name;
        }
    }
}
