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
    // ambos sirven para lo mismo sin importar el tipo de dato

    static int GetArrayLenght<T>(T[] array)
    {
        return array.Length;
    }

}
// clases genericas - 
class Box<T>
{
    public T? content { get; set; }

    public void show()
    {
        Console.WriteLine($"contenido: {content}");
    }
}