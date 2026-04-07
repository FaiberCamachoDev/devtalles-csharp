partial class Program
{
    static void Lvl1()
    {
            Console.WriteLine("+ of numbers!");
            

                Console.Write("Enter first number: ");
                int firstNumber = IntValidator();
                
            
                Console.Write("Enter second number: ");
                int secondNumber = IntValidator();
            
            int total = firstNumber + secondNumber;
            Console.WriteLine($@"your 1 number was: {firstNumber},
your 2 number was: {secondNumber}
the total is: {total}");
    }
}