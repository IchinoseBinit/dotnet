using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class Player : Human
    {
        private double salary;
        private string country;
        private string clubName;

        public Player(string name, int age, double salary, string address,  string clubName, string color):base(name, address, age, color)
        {
            this.salary = salary;
            this.clubName = clubName;
            this.country = "Nepal";
        }



        public override void Display()
        {
            base.Display();
            Console.WriteLine("The salary is "+salary);
            Console.WriteLine("The country is "+country);
            Console.WriteLine("The club name is "+clubName);
        }
    }
}
