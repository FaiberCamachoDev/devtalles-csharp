partial class Program
{
    static void WriterFileExample()
    {
        var filePath = "./05-Files/output.txt";

        // 1. Escribir texto (sobreescribe si ya existe)
        using (var writer = new StreamWriter(filePath))
        {
            writer.WriteLine("iwiwwiwiw reemplazo linea 1");
            
        }

        // 2. Agregar contenido sin sobreescribir (append: true)
        using (var writer = new StreamWriter(filePath, append: true))
        {
            writer.WriteLine("otra linea sin borrar lo anterior");
        }

        // 3. Leer el archivo para verificar lo escrito
        var lines = File.ReadLines(filePath);
        foreach (var line in lines)
        {
            WriteLine(line);
        }

        // 4. Escribir múltiples líneas de golpe con File.WriteAllLines
        var data = new[] { "Manzana", "Pera", "Uva" };
        File.WriteAllLines("./05-Files/frutas.txt", data);

        // 5. Escribir todo el texto de una vez con File.WriteAllText
        File.WriteAllText("./05-Files/nota.txt", "Esto sobreescribe todo el archivo de una sola vez.");

        // 6. Verificar existencia antes de escribir
        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, "Archivo creado solo si no existía");
        }
        else
        {
            WriteLine("Archivo ya existe");
        }
    }
}