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


        private string? firstName;
        private string? lastName;
        private DateTime birthday;


        public Person(string? firstName, string? lastName, DateTime birthday)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
        }

        private string readonlyPropertyAge;
        public string Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age = now.Year - birthday.Year;
                if (now.Month < birthday.Month || (now.Month == birthday.Month && now.Day < birthday.Day))
                {
                    age--;
                }
                return age.ToString();
            }


        }
    }
}
