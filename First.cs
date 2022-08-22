public class First {

    public First() {

    }

    public static double sumValue;
    // Declaration
    public static string name  = "Binit";
    // Declaration && Initialization

    public static void Main(String[] args) {
        Console.WriteLine("Hello world");
        sumValue = Add(5, 10);
        Display();
        // Assignation/ Initialization
    }

    public static double Add(double firstNum, double secondNum) {
        return firstNum+secondNum;
    }

    public static void Display() {
        Console.WriteLine(sumValue);
    }

}