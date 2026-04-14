partial class Program
{
    static void PrintFactorial(int number)
    {
        WriteLine($"factorial del numero {number} desde el 1 hasta el {number} ");
        for (int i = 1; i <= number; i++)
        {
            WriteLine($"{i}! = {Factorial(i)} ");
        }
    }

    static int Factorial(int number)
    {
        int result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return  result;
    }
}