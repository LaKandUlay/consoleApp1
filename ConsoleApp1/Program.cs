namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please Enter first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Please Enter last name");
        string lastName = Console.ReadLine();

        Console.WriteLine("Hello, {0}, {1}", firstName, lastName);

        string x = "Loste Jacob";
        int y = 123;
        int j = 111;
        string c = "Eldo";

        Console.WriteLine("{0} and {1} and {2}", y, x, j);
    }
}
