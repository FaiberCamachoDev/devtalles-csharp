partial class Program
{
    static void Collections()
    {
        List<String> Names = ["Luis","Maria","pedro"];
        Names.Add("Ana");
        // ShowNames(Names);
        // WriteLine("Dsp de remover luis");
        Names.Remove("Luis");
        // ShowNames(Names);
        
        // diccionario, clave valor
        Dictionary<int, string> student = new()
        {
            { 1, "Ana" },
            { 2, "Reycon" },
            { 3, "Juli" }
        };
        // para agregar cosas
        student.Add(4, "Robertototo");
        // ShowStudents(student);
        //remove by key
        student.Remove(1);
        // WriteLine("eliminado key 1 (ana)");
        // ShowStudents(student);
        
        
        //hashset - para evitar duplicados, aun asi se quiera ingresar, no lo inserta.
        HashSet<string> users = ["Luis", "Pedro", "Pablo"];
        users.Add("Melissa");
        users.Add("Gab");
        users.Add("Luis");
        ShowUsers(users);
    }

    private static void ShowUsers(HashSet<string> users)
    {
        foreach (var u in users)
        {
            WriteLine(u);
        }
    }

    private static void ShowStudents(Dictionary<int, string> student)
    {
        foreach (var e in student)
        {
            WriteLine($"key: {e.Key}  value: {e.Value}");            
        }
    }

    private static void ShowNames(List<string> Names)
    {
        foreach (var n in Names)
        {
            WriteLine(n);
        }
    }
}