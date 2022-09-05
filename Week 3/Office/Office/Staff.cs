using System;

namespace Office
{
    public class Staff
    {
        private string name;
        private int age;
        private double salary;
        private double experience;

        public string GetName()
        {
            if (name.Length > 0)
            {
                return name;
            } else
            {
                return "the value of name is not set";
            }
        }

        public int GetAge()
        {
            return age;
        }

        public double GetExperience()
        {
            return experience;
        }

        public double GetSalary()
        {
            return salary;
        }

        public void SetName(String name)
        {
            this.name = name;
        }

        public void SetAge(int age)
        {
            if (age > 0)
            {
                this.age = age;
            }
        }

        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

        public void SetExperience(double experience)
        {
            this.experience = experience;
        }

        //default constructor

        //parameterized constructor
        public Staff(string name, int age, double salary, double experience)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
            this.experience = experience;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("The name is " + GetName());
            Console.WriteLine("The age is " + age);
            Console.WriteLine("The salary is " + salary);
            Console.WriteLine("The experience is " + experience);
        }
    }
}
