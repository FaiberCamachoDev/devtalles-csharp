partial class Program
{
    static void FileExample()
    {
        // clase file
        var filePath = "./05-Files/example.txt";
        var content = File.ReadAllText(filePath);
        // WriteLine(content);
        
        var lines = File.ReadLines(filePath);
        foreach (var line in lines)
        {
            WriteLine(line);
        }
        // se pueden crear y eliminar, buscar dsp
    }
}