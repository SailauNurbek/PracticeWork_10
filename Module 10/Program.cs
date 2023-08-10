namespace Module_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Class1 person = new Class1();

            Console.WriteLine("Name:" + person.Name);
            Console.WriteLine("Sur name:" + person.SurName);
            Console.WriteLine("Patronymic:" + person.Patronymic);
            Console.WriteLine("Number:" + person.Number);

            Console.WriteLine();
            Console.WriteLine("Change a new number");
            person.setNumber();
            Console.WriteLine("New number:" + person.Number);
        }
    }
}