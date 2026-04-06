partial class Program
{
    static void Lvl3()
    {
        Console.WriteLine("«Fill Fields»");
        Console.Write("Enter your name: ");
        string? inputName = Console.ReadLine();
        Console.Write("Enter your lastname: ");
        string? inputLastName = Console.ReadLine();

        string fullName = inputName+" "+inputLastName;
        Console.WriteLine($"Hi Mr. {fullName}");
    }
}