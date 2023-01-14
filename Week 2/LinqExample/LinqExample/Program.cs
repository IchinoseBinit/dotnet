using LinqExample;

public class Program
{

    // Language Integrated Query
    public static void Main(string[] args)
    {
        List<Person> list = new List<Person>();
        list.Add(new Person("Udit", "Bhaktapur", 11));
        list.Add(new Person("Rabina", "Bhaktapur", 81));
        list.Add(new Person("Dipti", "Kathmandu", 2));
        list.Add(new Person("Rushma", "Bhaktapur", 13));
        list.Add(new Person("Binit", "Kathmandu", 24));

        //string[] names = { "Dipti", "Rushma", "Udit", "Binit", "Isha"};

        var query = list.Where(e => e.Id > 10 && e.Address == "Bhaktapur");
        foreach (Person p in query)
        {
            Console.WriteLine(p.ToString());
        }
        //var query = from person in list where person.Name.Contains("B") select person;
        /**
        */

        int[] numbers = { 0,1,2,3,4,5,6,7};

        // var newQuery = list.OrderBy(x => x.Id);
        var newQuery = list.GroupBy(x => x.Address);
        Console.WriteLine(newQuery);    
        // list.Where(x => x.Name.Length < 6).OrderBy(x => x.Name);
        
        Console.WriteLine("The names are");
        foreach(var p in newQuery)
        {
            Console.WriteLine(p.Key+ ": ");
            foreach (var value in p)
            {
                Console.WriteLine(value.ToString());   
            }
        }
        

        // Console.WriteLine(list.Max(x => x.Id));

        
        List<string> address= new List<string>() { "Kathmandu", "Pokhara", "Butwal", "Birgunj", "Hetauda"};
        List<string> address2 = new List<string>() { "Dharan", "Biratnagar", "Ilam", "Janakpur", "Hetauda", "Kathmandu" };

        //var result = address.Union(address2);
        /**
        var result = address.Concat(address2);
        foreach(string s in result)
        {
            Console.WriteLine(s);
        }
        */


    }
}