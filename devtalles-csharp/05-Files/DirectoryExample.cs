partial class Program
{
    static void DirectoryExample()
    {
        //creacion de un directorio
        var directoryPath = "./05-Files/";
        Directory.CreateDirectory($"{directoryPath}/DirExample");
        
        // Directory.Delete($"{directoryPath}/DirExample", true); // recursive true es para borrarlo si tiene contenido.
        
        // tambien se puede verificar la existencia con metodo exists dentro de un if.
    }
}