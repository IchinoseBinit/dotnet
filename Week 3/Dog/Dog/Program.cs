namespace Dog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dog johnny = new Dog();
            //classname objectname/variablename = keyword constructor
            johnny.name = "Johnny";
            johnny.ownerName = "Deepti";
            johnny.breed = "Labrador";
            johnny.age = 10;
            johnny.height = 120;
            johnny.weight = 20;
            johnny.DisplayDogDetails();

            string name;
            

            Dog tyson = new Dog();
            tyson.name = "Tyson";
            tyson.breed = "Pug";
            tyson.age = 09;
            tyson.height = 90;
            tyson.weight = 15;
            tyson.DisplayDogDetails();
        }
    }
}