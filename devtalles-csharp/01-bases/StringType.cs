partial class Program
{
    static void ShowStringType()
    {
        string name = "Juan";
        string message = "Hola " + name; // concatenando
        string interpolatedMessage = $"Hola {name}"; // interpolando
        Console.WriteLine(message); 
        Console.WriteLine(interpolatedMessage);
        
        Console.WriteLine($"Your name have {name.Length} characters");
        
        Console.WriteLine($"your name on MAYUS is {name.ToUpper()}");
        Console.WriteLine($"your name on MAYUS is {name.ToLower()}");

        int number = 20;
        Console.WriteLine(number.ToString().GetType());
        bool isString = true;
        Console.WriteLine(isString.ToString().GetType());
    }
}