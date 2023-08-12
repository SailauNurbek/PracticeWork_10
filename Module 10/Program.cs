namespace Module_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Consultant person = new Consultant();

            Console.WriteLine("Name:" + person.Name);
            Console.WriteLine("Sur name:" + person.SurName);
            Console.WriteLine("Patronymic:" + person.Patronymic);
            Console.WriteLine("Number:" + person.Number);
            Console.WriteLine("Pasport Id: " + person.showId());

            Console.WriteLine();
            Console.WriteLine("Change a new number");
            person.setNumber();
            Console.WriteLine("New number:" + person.Number);
            

            Console.WriteLine();
            Manager manager = new Manager();
            Console.WriteLine("Pasport Id: " + manager.showId() + " Manager");

        }
    }
} 