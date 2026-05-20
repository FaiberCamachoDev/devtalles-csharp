using System.Text.Json;

partial class Program
{
    class Character
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Alias { get; set; }
        public string? Team { get; set; }
    }

    public static void ManageJsonFile()
    {
        List<Character> characters =
        [
            new Character { Id = 1, Name = "Peter Parker", Alias = "Spider-Man",      Team = "Avengers" },
            new Character { Id = 2, Name = "Tony Stark",   Alias = "Iron Man",        Team = "Avengers" },
            new Character { Id = 3, Name = "Steve Rogers", Alias = "Capitán América", Team = "Avengers" }
        ];

        var jsonPath = "./05-Files/characters.json";

        // 1. Serializar lista a string JSON con formato legible
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(characters, options);
        WriteLine("-- JSON generado --");
        WriteLine(jsonString);

        // 2. Guardar JSON en archivo
        File.WriteAllText(jsonPath, jsonString);
        WriteLine($"\nArchivo guardado en: {jsonPath}");

        // 3. Deserializar desde archivo a lista de objetos
        string jsonFromFile = File.ReadAllText(jsonPath);
        var loadedCharacters = JsonSerializer.Deserialize<List<Character>>(jsonFromFile);

        WriteLine("\n-- Personajes deserializados --");
        foreach (var c in loadedCharacters!)
            WriteLine($"[{c.Id}] {c.Name} | {c.Alias} | {c.Team}");

        // 4. Agregar un personaje y actualizar el archivo
        loadedCharacters.Add(new Character { Id = 4, Name = "Bruce Banner", Alias = "Hulk", Team = "Avengers" });
        File.WriteAllText(jsonPath, JsonSerializer.Serialize(loadedCharacters, options));
        WriteLine("\nPersonaje agregado y archivo actualizado.");

        // 5. Deserializar un solo objeto desde un JSON string
        string singleJson = """{"Id":5,"Name":"Natasha Romanoff","Alias":"Black Widow","Team":"Avengers"}""";
        var single = JsonSerializer.Deserialize<Character>(singleJson);
        WriteLine($"\nPersonaje individual: {single!.Name} aka {single.Alias}");

        // 6. Buscar un personaje en la lista deserializada y modificarlo
        var hulk = loadedCharacters.FirstOrDefault(c => c.Alias == "Hulk");
        if (hulk is not null)
        {
            hulk.Team = "S.H.I.E.L.D";
            File.WriteAllText(jsonPath, JsonSerializer.Serialize(loadedCharacters, options));
            WriteLine($"\nEquipo de {hulk.Name} actualizado a: {hulk.Team}");
        }
    }
}
