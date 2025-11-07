using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_FirstOOP
{
    internal class Person
    {
        //Attribute (Datenkomponenten), Member
        private string firstName;           //Attribute immer private
                                            //Sichtbarkeit, Datentyp des Attributs, Name des Attributs 
        private string lastName;
        private int age;

        //Konstruktor
        public Person(string firstName, string lastName, int age)       //Konstruktor mit Parameterliste
        {
            //dient zur Initialierung des Objekts (Attribute) 
            this.firstName = firstName;         //this.firstName -->Attribut
                                                //firstName -->Parameter
            this.lastName = lastName;
            this.age = age;
        }

    }
}