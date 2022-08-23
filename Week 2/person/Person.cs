

using System;

namespace hello
{
    public class Person
    {
        public string name;
        public int age;
        public string profession;
        public string address;
        public string city;

        public Person()
        {
            Console.WriteLine("I am called");
            city = "";
        }

        public void DisplayDetails()
        {
            Console.WriteLine("The person name is " + name);
            Console.WriteLine("The person age is " + age);

            Console.WriteLine("The person profession is " + profession);
            if (city.Length != 0)
            {
                Console.WriteLine("The person city is " + city);
            }

            Console.WriteLine("The person address is " + address + "\n");

        }

    }
}
