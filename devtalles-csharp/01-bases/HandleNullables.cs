partial class Program
{
    static void HandleNullables()
    {
        // no nunificable
        string firstname = "carlos";
        //nunificable
        string? lastname = null;
        Console.WriteLine($"{firstname} {lastname}");
        if (lastname != null)
        {
            Console.WriteLine($" apellido: {lastname}");
        }
        else
        {
            Console.WriteLine("apellido no especificado");
        }
        // operador de coalescencia nula ??
        Console.WriteLine($"Apellido: {lastname ?? "Apellido no especificado!"} ");
        
        // operador de acceso nulo seguro ?.

        string? text = null;
        Console.WriteLine(text?.Length);
        
        //esto es para manejar nulos y validacion.
        
        // operador ternario
        int age = 17;
        string categoria = age >= 18 ? "Es adulto" : "Es menor";
        Console.WriteLine($"age: {age}, category: {categoria}");
    }
}