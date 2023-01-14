using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Person
    {
        private string name;
        private string age;
        private string address;
        private bool isReading;
        private bool isSports;

        public String GetName ()
        {
            return name;
        }
        public String GetAge()
        {
            return age;
        }
        public String GetAddress()
        {
            return address;
        }

        public Person(string name, string age, string address, bool isReading, bool isSports)
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.isReading = isReading;
            this.isSports = isSports;
        }

        void display()
        {
            Console.WriteLine("The name is " + name);
            Console.WriteLine("The age is " + age);
            Console.WriteLine("The address is " + address);
            if (isReading)
            {
                Console.WriteLine("The hobby is reading");
            } 
            if (isSports)
            {
                Console.WriteLine("The hobby is sports");

            }
        }
    }
}
