using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace _01_FirstOOP

{

    internal class tractor

    {

        //Attribute

        private string brand;

        private string type;

        private double powerInKW;

        //Konstructor

        public tractor(string brand, string type, double powerInKW)

        {

            this.brand = brand;

            this.type = type;

            this.powerInKW = powerInKW;

        }

        //Methoden

        public double GetPowerInHp()        //Zugriffsmodifikator, Rückgabewert, Name der Methode, Parameterliste (leer) 

        {

            return this.powerInKW * 1.36;

        }

        public string GetInfo()                 //Methoden großgeschrieben 

        {

            return this.brand + " " + this.type;

        }

    }

}

