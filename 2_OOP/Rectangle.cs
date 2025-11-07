using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_OOP
{
    internal class Rectangle
    {
        private double length;                  //Attribute
        private double width;

        public Rectangle(double length, double width)      
        {
           
            this.length = length;            //Konstruktor
            this.width = width;
        }

        public double Area()                 // Methode1 
        {
            return this.length * this.width;

        }

        public double Circumference()        //Methode2
        {
            return (this.length + this.width) * 2;
        }

        public void Resize(double factor)
        {
            // Soll die Fläche um den Faktor vergrößern oder verkleinern
            this.length = this.length * Math.Sqrt(factor);              // Wurzel vom Faktor, danut Seitenlänge korrekt skaliert wird
            this.width = this.width * Math.Sqrt(factor);
        }
    }
}
