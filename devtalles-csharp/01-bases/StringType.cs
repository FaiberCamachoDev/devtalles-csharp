partial class Program
{
    static void ShowStringType()
    {
        string name = "Juan";
        string message = "Hola " + name; // concatenando
        string interpolatedMessage = $"Hola {name}"; // interpolando
        Console.WriteLine(message); 
        Console.WriteLine(interpolatedMessage);
    }
}