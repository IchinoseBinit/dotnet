namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomArray<string> array = new CustomArray<string>();
            array.Add("Deepti");
            array.Add("Binit");
            array.Add("Rushma");
            array.Add("Rabina");
            array.Add("Udit");
            array.ToString();
            array.Add("Abhishek");
        }

        
    }
}