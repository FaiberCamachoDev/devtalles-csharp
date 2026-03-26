partial class Program
{
    static void SalaryCalculator()
    {
        Console.Write("Insert your name: ");
        string name = Console.ReadLine();
        
        Console.Write("How many hours do you work?: ");
        int hoursWorked = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Insert the salary per hour: ");
        int salaryHour = Convert.ToInt32(Console.ReadLine());
        
        int totalSalary = salaryHour * hoursWorked;
        Console.WriteLine($"Your total salary {name} is: {totalSalary}");
    }
}