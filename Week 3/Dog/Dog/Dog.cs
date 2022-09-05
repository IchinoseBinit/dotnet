using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    public class Dog
    {
        //name, age, height, weight, breed, owner's name
        public string name;
        public int age;
        public double height;
        public double weight;
        public string breed;
        public string ownerName;

        //constructor
        public Dog()
        {
            ownerName = "";
        }

        public void DisplayDogDetails()
        {
            Console.WriteLine("The name of the dog is "+name);
            Console.WriteLine("The age of the dog is " + age);
            Console.WriteLine("The height of the dog is "+ height);
            Console.WriteLine("The weight of the dog is "+ weight);
            Console.WriteLine("The breed of the dog is "+ breed);
            if (ownerName.Length != 0)
            {
                Console.WriteLine("The owner's name of the dog is " + ownerName);
            }
        }
    }
}
