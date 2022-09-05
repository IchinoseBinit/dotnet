namespace Office
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Staff staff = new Staff("Binit Koirala", 25, 10000, 1);
            //dog.name = "";
            staff.DisplayDetails();
            staff.SetName("Alish");
            
            staff.DisplayDetails();

            staff.SetName("");

            staff.DisplayDetails();


        }
    }
}