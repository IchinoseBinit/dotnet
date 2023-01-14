using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    internal class Person
    {

        public string Name { get; set; }
        public int Id { get; set; } 
        public string Address { get; set; }

        public Person(string name, string address, int id)
        {
            Name= name;
            Id= id;
            Address = address;
        }

        public override string ToString()
        {
            return Id+": "+Name + ", " +Address;
        }
    }
}
