using System;
using System.Collections.Generic;
using System.Text;

namespace ParallelLinq.Model
{
    public class Persons
    {
        public List<Person> List { get; set; }

        public Persons()
        {
            List = new List<Person>
            {
                new Person {Name = "Alan", City = "Hull"},
                new Person {Name = "Beryl", City = "Seattle"},
                new Person {Name = "Charles", City = "London"},
                new Person {Name = "David", City = "Seattle"},
                new Person {Name = "Donald", City = "London"},
                new Person {Name = "Leonardo", City = "London"},
                new Person {Name = "Will", City = "London"},
                new Person {Name = "John", City = "London"},
                new Person {Name = "Wilson", City = "London"}
            };
        }
    }
}
