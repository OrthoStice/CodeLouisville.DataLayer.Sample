
using System;
using System.Collections.Generic;


namespace Sample
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Sex { get; set; }
        public List<Person> Parents { get; private set; } = new List<Person>();
    }
}