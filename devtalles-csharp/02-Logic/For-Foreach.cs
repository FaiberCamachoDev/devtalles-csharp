partial class Program
{
    static void Recorrer()
    {
        //for
        for (int i = 0; i <= 5; i++) // inicializacion | condicion | aumento
        {
            WriteLine($"{i}");
        }
        
        //for each (es para recorrer listas, diccionarios o arrays[])
        List<int> listNUmbers = new List<int> { 1, 2, 3, 4, 5 };
        foreach (var number in listNUmbers)
        {
            WriteLine($"{number}");
        }
        
        string[] names = ["paula","paula","paula" ];
        foreach (var name in names)
        {
            WriteLine($"{name}");
        }
        Dictionary<int, string> dictionary = new Dictionary<int, string>
        {
            { 1, "Ana" }, // key = value
            { 2, "Maria" },
            { 3, "Elena" }
        };
        foreach (var student in dictionary)
        {
            WriteLine($"{student.Key}");
            WriteLine($"{student.Value}");
            WriteLine($"{student}");
        }
    }
}