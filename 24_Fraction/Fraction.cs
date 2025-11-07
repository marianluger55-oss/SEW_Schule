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
        }
    }
}


