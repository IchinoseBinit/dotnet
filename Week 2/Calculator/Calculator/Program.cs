
namespace Calculator;
public class Program

{
    public static void Main(String[] args)
    {
        Console.WriteLine("Hello World");
        Student students = new Student();
        // Class name variable name =  new (keyword) constructor
        students[0] =  "Udit";
        students[1] = "Abhishek";
        students[2] = "Deepti";
        students[3] = "Rushma";
        students.SetAddress("Kathmandu");
        for(int i = 0; i < 4; i++)
        {
            Console.WriteLine(students[i]);
        }
        Console.WriteLine("The address is " + students.GetAddress());

        Console.WriteLine("\n\nNew Names\n\n");

        students[3] = "Rabina";
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(students[i]);
        }
    }
}