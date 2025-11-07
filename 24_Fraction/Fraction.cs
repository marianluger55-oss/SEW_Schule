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
    }
}
