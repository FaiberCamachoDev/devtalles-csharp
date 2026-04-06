partial class Program
{
    static void Lvl1()
    {
            Console.WriteLine("+ of numbers!");
            int firstNumber = 0;
            int secondNumber = 0;
            while (true)
            {
                Console.Write("Enter first number: ");
                int input1 = IntValidator(firstNumber);
                break;
            }

            while (true)
            {
                Console.Write("Enter second number: ");
                IntValidator(secondNumber);
                break;
            }
            
            
            int total = firstNumber + secondNumber;
            Console.WriteLine($@"your 1 number was: {firstNumber},
your 2 number was: {secondNumber}
the total is: {total}");
    }
}