using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter5
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Uri Picture { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
