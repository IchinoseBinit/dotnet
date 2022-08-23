using System;

namespace hello
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person personOne = new Person();
            personOne.name = "Udit";
            personOne.age = 22;
            personOne.profession = "Student";
            personOne.address = "Duwakot";
            personOne.city = "Bhaktapur";
            personOne.DisplayDetails();
            

            Person personTwo = new Person();
            personTwo.name = "Abhishek";
            personTwo.age = 26;
            personTwo.profession = "Student";
            personTwo.address = "Shantinagar";
            personTwo.DisplayDetails();

            Person personThree = new Person();
            personThree.name = "Durga";
            personThree.age = 22;
            personThree.profession = "Student";
            personThree.address = "Pepsicola";
            personThree.DisplayDetails();

        }
    }
}
