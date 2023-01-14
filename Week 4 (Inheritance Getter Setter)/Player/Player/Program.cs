namespace Player
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Player player = new Player("Abhishek", 25, 25000, "Dharan", "Manang Marsyangdi", "White");
            //Player player = new Player( 25000, "Manang Marsyangdi");
            player.Display();

            Student student = new Student("Binit", "Dharan", 25, "White", "A1", "3rd Sem", "A", "BCA");
            student.Display();

            string[] ar = { "1", "Binit" };
            int[] numArr = { 1, 2, 3, 4 };

            

            List<string> list = new List<string>();
            list.Add("Binit");
            list.Add("Binit");
            list.Add("Binit");
            
            list.Add("Binit");
            list.Add("Binit");
            list.Add("Binit");
            list.Add("Binit");
        }
    }
}