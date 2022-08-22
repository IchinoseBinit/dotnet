
namespace Calculator;
public class Program

{
    public static void Main(String[] args)
    {
        Console.WriteLine("Hello World");
        Sum sum = new Sum();
        // Class name variable name =  new (keyword) constructor
        double totalSum = sum.GetSum(30, 55);
        Console.WriteLine(totalSum);
    }
}