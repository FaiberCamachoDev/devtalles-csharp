partial class Program
{
    static void Lvl2()
    {
        Console.WriteLine("«Enter 3 double califications»");
        Console.Write("Enter first number: ");
        string? inputF = Console.ReadLine();
        bool isValid = double.TryParse(inputF, out double firstNumber);
        Console.Write("Enter second number: ");
        string? inputS = Console.ReadLine();
        bool isValid2 = double.TryParse(inputS, out double secondNumber);
        Console.Write("Enter third number: ");
        string? inputT = Console.ReadLine();
        bool isValid3 = double.TryParse(inputT, out double thirdNumber);
        
        double rate = (firstNumber + secondNumber + thirdNumber) / 3d;

        if (rate >= 3)
        {
            Console.WriteLine($"your note is: {rate}, you approve!");
        }
        else
        {
            Console.WriteLine($"your note is: {rate}, you failed!");
        }
        

    }
}