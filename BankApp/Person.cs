using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Person
    {
        public string firstName { get; protected set; }
        public string lastName { get; protected set; }
        public int age { get; protected set; }

        public Person(String firstName, String lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }



    }
}
