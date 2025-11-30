using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Presentation;
using System;

namespace _24_Fraction
{
    internal class Fraction
    {
        private int _nominator;
        private int _denominator;

        // Zähler
        public int Nominator
        {
            get => _nominator;
            set
            {
                _nominator = value;
                Shorten(); // Bruch nach jeder Änderung kürzen
            }
        }

        // Nenner
        public int DeNominator
        {
            get => _denominator;
            set
            {
                if (value == 0)
                    throw new DivideByZeroException("Denominator cannot be zero.");
                _denominator = value;
                Shorten(); // Bruch nach jeder Änderung kürzen
            }
        }

        // Konstruktor
        public Fraction(int nominator, int denominator)
        {
            if (denominator == 0)
                throw new DivideByZeroException("Denominator cannot be zero.");

            _nominator = nominator;
            _denominator = denominator;

            Shorten(); // sofort kürzen
        }

        // Bruch als Text
        public string GetFraction()
        {
            return $"{_nominator} / {_denominator}";
        }

        // Dezimalwert
        public double GetValue()
        {
            return (double)_nominator / _denominator;
        }

        // Bruch kürzen
        private void Shorten()
        {
            if (_nominator == 0)
            {
                _denominator = 1; // 0/any = 0/1
                return;
            }

            int gcd = Gcd(Math.Abs(_nominator), Math.Abs(_denominator));

            _nominator /= gcd;
            _denominator /= gcd;

            // Negativen Vorzeichen nur im Zähler speichern
            if (_denominator < 0)
            {
                _denominator *= -1;
                _nominator *= -1;
            }
        }

        // Euklidischer Algorithmus
        private int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;

            public Fraction Add(Fraction other)
        {
            int newDenominator = this.DeNominator * other.DeNominator;
            int newNominator = this.Nominator + other.DeNominator + other.Nominator * this.DeNominator; 
            Fraction newFraction = new Fraction(newDenominator, newNominator);
            newFraction.Shorten();
            return newFraction; 
        }

        private Fraction Multiply(Fraction multi) {

            int multiNominator = this.Nominator * multi.Nominator;
            int multiDenominator = this.DeNominator * multi.DeNominator;
            Fraction newFraction = new Fraction(multiDenominator, multiNominator);
            newFraction.Shorten();
            return newFraction;


        }
        private Fraction Sub(Fraction subtrac)
        {
            int newDenominator = this.DeNominator * subtrac.DeNominator;
            int newNominator = this.Nominator - subtrac.DeNominator + subtrac.Nominator * this.DeNominator;
            Fraction newFraction = new Fraction(newDenominator, newNominator);
            newFraction.Shorten();
            return newFraction;
        }

        private Fraction Divide(Fraction dividend) {
            int newDenominator = this.DeNominator * dividend.Nominator;
            int newNominator = this.Nominator * dividend.DeNominator;
            Fraction newFraction = new Fraction(newDenominator, newNominator);
            newFraction.Shorten(); 
            return newFraction;
            
        }
    }
}

