using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5.Shared
{
    public class Person
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;

        public Person(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public (string, DateTime) GetData()
        {
            return (PersonName:this.Name, PersonDate : this.DateOfBirth);
    }
    }

   
}
