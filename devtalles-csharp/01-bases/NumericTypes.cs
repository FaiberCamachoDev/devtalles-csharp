partial class Program
{
    static void ShowNumericType()
    {
        int inegerNumber = 42;
        double decimalNumber = 3.1416d;
        float floatNumber = 274f;

        long longNumber = 300_200_100L;
        decimal monetaryNumber = 99.99m;
        
        Console.WriteLine($"integer: {inegerNumber}, doubleNumber: {decimalNumber}, float: {floatNumber}, longNumber: {longNumber}, monetaryNumber: {monetaryNumber} ");
    }
}