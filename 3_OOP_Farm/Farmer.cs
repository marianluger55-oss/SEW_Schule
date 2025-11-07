using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_OOP_Farm
{
    internal class Farmer
    {
        private string firstName;
        private string lastName;
        private int age;
        private Dog dog;
        private Cow[] cows;

        public Farmer(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.dog = null;            // das Attribut dog hat keinen Wert
            this.cows = new Cow[5];     // Initialisierung des Arrays (Größe wird festgelegt). Defaultwert ist null --> Array mit 5x null
        }

        public string GetInfo()
        {
            if (this.dog != null)
            {
                return $"Name: {this.firstName} {this.lastName}, Alter: {this.age}, Hund: {this.dog.GetInfo()}";

            }
            else
            {
                return $"Name: {this.firstName} {this.lastName}, Alter: {this.age}";
            }
        }

        public void SetDog(Dog dog)
        {
            this.dog = dog;
        }

        public int GetNrOfCows()
        {
            int nrOfCows = 0;
            for (int i = 0; i < this.cows.Length; i++)
            {
                if (this.cows[i] != null)
                {
                    nrOfCows++;
                }
            }
            return nrOfCows;
        }

        public void AddCow(Cow cow)
        {
            int nrOfCows = this.GetNrOfCows();
            cows[nrOfCows] = cow;
        }

        public void RemoveCow()
        {
            // immer letzte Kuh entfernen
            int nrOfCows = this.GetNrOfCows();
            cows[nrOfCows - 1] = null;
        }

        public int GetMaxNrOfCows()
        {
            return this.cows.Length;
        }
    }
}
