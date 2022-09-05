using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class Human
    {
        private string name;
        private string address;
        private int age;
        private string color;

        public Human(string name, string address, int age, string color) 
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.color = color;
        }

        public string Name
        {
            get
            {
                if (name != "") 
                { 
                    return name;
                }
                else
                {
                    return "noname";
                }
                
            }
            set
            {

                name = value;
            }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }    
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public virtual void Display()
        {
            Console.WriteLine("The name is " + name);
            Console.WriteLine("The age is " + age);
            Console.WriteLine("The address is " + address);
            Console.WriteLine("The color is " + color);
        }
    }
}
