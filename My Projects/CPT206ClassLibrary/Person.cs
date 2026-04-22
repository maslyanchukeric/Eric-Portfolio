using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CPT206ClassLibrary
{
    class Person
    {
        //feilds

        //properties
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Person> Childern = new List<Person>();

        //readonly properties
        public readonly DateTime Instantied;

        //constructors
        public Person(string name)
        {
            Name = name;
            DateOfBirth = null;
            Instantied = DateTime.Now;
        }
        //methods
    }
}
