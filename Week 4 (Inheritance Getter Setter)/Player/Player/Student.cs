using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class Student : Human
    {
        private string rollNo;
        private string className;
        private string section;
        private string course;

        public Student(string name, string address, int age, string color, string rollNo, string className, string section, string course) : base(name, address, age, color)
        {
            this.rollNo = rollNo;
            this.className = className;
            this.section = section;
            this.course = course;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("The roll no is " + rollNo);
            Console.WriteLine("The section is " + section);
            Console.WriteLine("The course is " + course);
            Console.WriteLine("The class is " + className);
        }

    }
}
