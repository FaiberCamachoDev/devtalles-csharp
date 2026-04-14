partial class Program
{
    static void AnonymousFunctions()
    {
     WriteLine($"square of the  tin = {LambdaSquare(8)}");   
    }
    // como crear una funcion anonima = Func<lo que entra | lo que sale> variableName = ....
    private static Func<int, int> square = delegate(int number) // palabra reservada delegate y luego indicar que ingresa como parametro
    {
        return number * number;
    };
    
    // forma mas concica para escribir funciones anonimas...
    // x (lo que ingresa, valor parametro) => (el retorno)
    private static Func<int, int> LambdaSquare = x => x * x;
    
}