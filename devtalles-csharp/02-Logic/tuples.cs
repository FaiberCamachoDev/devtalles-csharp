partial class Program
{
    static void tuples()
    {
        // para definir una tupla se comienza definiendo los tipos de datos
        (int, string) myTuple = (42, "hola");
        WriteLine($"{myTuple.Item1} {myTuple.Item2}");
        
        (int Number, string Text) myTuple2 = (33, "jijijijj");
        WriteLine($"{myTuple2.Number} {myTuple2.Text}");
        var operations = Operations(20, 25);
        WriteLine($@"Sum = {operations.sum}
substraction = {operations.substraction}");
    }

    static (int sum, int substraction) Operations(int a, int b)
    {
        return  (a + b, a - b);
    }
}