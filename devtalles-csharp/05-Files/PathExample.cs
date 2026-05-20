partial class Program
{
    static void PathExample()
    {
        var filePath = "./05-Files/example.txt";
        var fileName = Path.GetFileName(filePath);
        WriteLine($"file name: {fileName}");
        var fileExtension = Path.GetExtension(filePath);
        WriteLine($"extension name: {fileExtension}");
        var dirName = Path.GetDirectoryName(filePath);
        WriteLine($"dir name: {dirName}");
        var combinedPath = Path.Combine("C:", "User", "Documents", "Ejemplo.txt");
        WriteLine($"combined path: {combinedPath}");
        var fullFilePath = Path.GetFullPath(filePath);
        WriteLine($"full path: {fullFilePath}");
    }
}