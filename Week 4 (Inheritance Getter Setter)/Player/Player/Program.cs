namespace Player
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Player player = new Player("Abhishek", 25, 25000, "Dharan", "Manang Marsyangdi", "White");
            //Player player = new Player( 25000, "Manang Marsyangdi");
            player.Display();
        }
    }
}