using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hue7._2
{
    internal class Breeding
    {
        // Belassen oder mit Inhalten füllen
    }
    
    internal class AnimalBirthCalculator
    {
        public DateTime CalculateBirthDate(DateTime conceptionDate, int gestationDays)
        {
            DateTime birthDate = conceptionDate.AddDays(gestationDays);
            return birthDate;
        }

        public void PrintBirthDate(DateTime conceptionDate, int gestationDays, string animalName)
        {
            DateTime birthDate = CalculateBirthDate(conceptionDate, gestationDays);
            Console.WriteLine($"{animalName} wurde am {birthDate:dd.MM.yyyy} erwartet (Befruchtungsdatum: {conceptionDate:dd.MM.yyyy}, Tragezeit: {gestationDays} Tage).");
        }
    }
}
