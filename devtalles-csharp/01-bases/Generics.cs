partial class Program
{
    static void Generics()
    {
        string[] Names = ["Daniela", "Ana", "Maria"];
        int[] Numbers = [1, 2, 3];
        Console.WriteLine(GetArrayLenght(Names));
        Console.WriteLine(GetArrayLenght(Numbers));
        //despues del box se especifica el tipo de dato porque es generico, puede ser cualquiera.
        Box<int> numberBox = new Box<int> { content = 50 };
        Box<string> stringBox = new Box<string> { content = "awawawawa" };
        numberBox.show();
        stringBox.show();
    }
    
    // metodos sin el uso de generico
    //para usarlo arriba debe ser por separado al int y string
    static int GetIntArraysLenght(int[] array)
    {
        return array.Length;
    }
    static int GetStringArraysLenght(string[] array)
    {
        return array.Length;
    }
    
    //metodos genericos
    // ESte sirve para lo mismo sin importar el tipo de dato

    static int GetArrayLenght<T>(T[] array) // <string> / <int>..... etc
    {
        return array.Length;
    }

}
// clases genericas 
class Box<T> // <string> / <int>..... etc
{
    public T? content { get; set; } 

    public void show()
    {
        Console.WriteLine($"contenido: {content}");
    }
    
    // ejemplooos by chatpgpt:
    // 1. Creamos una caja y le pegamos la etiqueta de "string"
//     Box<string> cajaDeTextos = new Box<string>();
//     cajaDeTextos.content = "Mis libros";
//     cajaDeTextos.show(); // Imprime: contenido: Mis libros
//
// // 2. Usamos el MISMO molde, pero ahora le pegamos la etiqueta "int"
//     Box<int> cajaDeNumeros = new Box<int>();
//     cajaDeNumeros.content = 100;
//     cajaDeNumeros.show(); // Imprime: contenido: 100
//
// // 3. Aprovechando el "?" (Caja vacía)
//     Box<string> cajaVacia = new Box<string>();
//     cajaVacia.content = null; // ¡Válido gracias al T?!
//     cajaVacia.show(); // Imprime: contenido:
}