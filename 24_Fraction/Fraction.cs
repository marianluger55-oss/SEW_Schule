using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Fraction
{
    internal class Fraction
    {
        // Properties 
        public int Nominator { get; set; }
        public int DeNominator { get; set; }

        public Fraction(int Nominator, int DeNominator)
        {
            this.Nominator = Nominator;
            this.DeNominator = DeNominator;
        }

        public string GetFraction()
        {
            return $"{this.Nominator} / {this.DeNominator}";
        }

        public double GetValue()
        {
            return (double)Nominator / (double)DeNominator;
        }

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

