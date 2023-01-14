using System.Xml.Linq;

namespace Convert
{
    public class Program
    {

        public delegate void printStatement(String name);

        public static int GetNum() => 5;

        // Lambda Expressions
        public static int GetSquareNum(int num) => num * num;

        /**
         * public static int GetSquareNum(int num) {
         *  return num * num;
         * }
         */
        public static void Main(string[] args)
        {
            try
            {
                /**
                Console.WriteLine("Hello! Please enter a number");
                string num = Console.ReadLine();
                double number = Double.Parse(num);
                Console.WriteLine("The square of the number is " + number * number);

                printStatement p = delegate(String name) {
                    Console.WriteLine("Hello World, Hi "+name);
                };

                printStatement printingStatement = x =>
                {
                    Console.WriteLine("Hello World, Hi from lamba expressions " + x);
                };

                p("Dipti");
                printingStatement("Rushma");
                int value = GetNum();
                Console.WriteLine(GetSquareNum(value));
                */

                List<Int32> list = new List<int>();
                list.Add(1);
                list.Add(2);   
                list.Add(3);    

                Console.WriteLine(list.Count);
                Console.WriteLine(list[3]);




            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Please enter a valid range");   
                //Console.WriteLine("Please enter a number");
            } finally
            {
                Console.WriteLine("My name is Udit");
            }
            Console.WriteLine("My name is Abhishek");
        }

        public static void GetName()
        {
            Console.WriteLine("");
        }
    }

    
}