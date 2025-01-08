using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Structs
{

    internal struct Person
    {
        public string? name;
        public int? age;

        public Person(int Age,string ? Name)
        {
            name = Name;
            age = Age;
            
        }
        public override string ToString() {
         return $"{name} and his age is {age}";
        }


    }
}
