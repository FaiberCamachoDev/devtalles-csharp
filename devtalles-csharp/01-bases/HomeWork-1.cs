partial class Program
{
    static void SalaryCalculator()
    {
        Console.Write("Insert your name: ");
        string? name = Console.ReadLine(); // ? es que permite valores nulos
        
        Console.Write("How many hours do you worked?: ");
        double hoursWorked = double.Parse(Console.ReadLine()!); // ! significa que permite valores nulos
        
        Console.Write("Insert the salary per hour: ");
        double salaryHour = double.Parse(Console.ReadLine()!);
        
        double totalSalary = salaryHour * hoursWorked;
        Console.WriteLine($"Your total salary {name} is: {totalSalary:C}");
    }
}// operaciones de decimales calcula mal --