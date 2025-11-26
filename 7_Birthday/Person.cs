using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _7_Birthday
{
    class Person
    {


        private string FirstName {  get; set; }
        private string LastName { get; set; }
        private DateTime Birthday { get; set; }

        public Person(string firstName, string lastName, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
        }

        private string readonlyPropertyAge;
        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age = now.Year - Birthday.Year;
                if (now.Month < Birthday.Month || (now.Month == Birthday.Month && now.Day < Birthday.Day))
                {
                    age--;
                }
                return age;
            }


        }

        public int DaysLived
        {
             get
            {
                DateTime now = DateTime.Now;
                TimeSpan lived = now - Birthday;
                return (int)lived.TotalDays;
            }
        }

        public int DaysUntilNextBirthday
        {
            get
            {
                DateTime now = DateTime.Now;
                DateTime nextBirthday = new DateTime(now.Year, Birthday.Month, Birthday.Day);
                if (nextBirthday < now)
                {
                    nextBirthday = nextBirthday.AddYears(1);
                }
                TimeSpan untilNextBirthday = nextBirthday - now;
                return (int)untilNextBirthday.TotalDays;
            }
        }














































































































    }
}
