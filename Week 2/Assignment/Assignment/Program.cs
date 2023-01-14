using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.Intrinsics.X86;

namespace SarojA1_1175_004
{
    class Program
    {
        public static void Main(string[] args)
        {
            DisplayInstruction();
            Console.WriteLine("Press any key when you are ready to begin....");
            Console.ReadKey();
            String name = GetFullName();
            String address = GetAddress();
            int minutes = GetMinutes();
            int kayakPrice = CalculateKayakRent(minutes);
            int extraMinute = minutes % 60;
            int hours = (minutes - extraMinute) / 60;
            Console.WriteLine("\nKayak rental price:");
            Console.WriteLine("For a kayak rental for "+ hours +" hour(s) and "+ extraMinute + " minutes, the price is $"+ double.Parse(kayakPrice.ToString()));
            Console.WriteLine("Press any key to see Canoe rental price\n");
            Console.ReadKey();
            double canoePrice = CalculateCanoeRent(minutes);
            Console.WriteLine("Canoe rental price:");
            Console.WriteLine("For a canoe rental for " + hours + " hour(s) and " + extraMinute + " minutes, the price is $"+canoePrice);

            DisplayDetails(name, address, minutes, kayakPrice, canoePrice);
            Console.ReadKey();
        }
        //public void DisplayMotto()
        //{ 

        //}
        public static void DisplayInstruction()
        {
            Console.WriteLine("SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS");
            Console.WriteLine("S\t\t\t\t\t\tS");
            Console.WriteLine("S        Sam's makes it fun in the sun          S");
            Console.WriteLine("S\t\t\t\t\t\tS");
            Console.WriteLine("SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS");


            Console.WriteLine(@"This application is computes rent for Kayak and Canoe
It takes a customer to enter his/her first name, last name, address and number of minutes
he/she wanted to rent a kayak and canoe
The application calculates the rental price of kayak and canoe and displays that.Two tests will be performed");
            Console.WriteLine();
        }
        public static string GetFullName()
        {
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please enter  your last name: ");
            string lastName = Console.ReadLine();
            return firstName + " " + lastName;
        }
        public static string GetAddress()
        {
            Console.Write("Please enter Your Address: ");
            return Console.ReadLine();
        }
        public static int GetMinutes()
        {
            Console.Write("Enter minutes you want to rent a kayak and canoe: ");
            return int.Parse(Console.ReadLine());
        }
        public static int CalculateKayakRent(int minutes)
        {
            //int totalminutes;
            //totalminutes = minutes;
            int hourlyRate = 40;
            int extraMinute = minutes % 60;
            int hours = (minutes - extraMinute) / 60;
            if (hours < 1)
            {
                return hourlyRate;
            }
            int kayakPrice = hours * hourlyRate + extraMinute;
            return kayakPrice;

        }
        public static double CalculateCanoeRent(int minutes)
        {
            double hourlyRate = 50.99;
            double extraMinute = minutes % 60;
            double hours = (minutes - extraMinute) / 60;
            if (hours < 1)
            {
                return hourlyRate;
            }
            double canoePrice = hours * hourlyRate + extraMinute;
            return canoePrice;
        }
        public static void DisplayDetails(string name, string address, int minutes, int kayakPrice, double canoePrice)
        {        
            Console.WriteLine("\nCustomer name: " + name);
            Console.WriteLine("Customer address: "+ address);
            Console.WriteLine("Minutes the kayak/canoe would be rented: "+ minutes);
            Console.WriteLine("Kayak rent would be: $"+ kayakPrice);
            Console.WriteLine("Canoe rent would be: $"+ canoePrice);
            Console.WriteLine("\nThanks for using Sam's rental app");
        }
    }
}