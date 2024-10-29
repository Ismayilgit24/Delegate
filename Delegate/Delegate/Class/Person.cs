using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Class
{
	internal class Person
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }

        public Person(string name, string surname, byte age)
        {
            FirstName = name;
            LastName = surname;
            Age = age;
        }
    }
}
