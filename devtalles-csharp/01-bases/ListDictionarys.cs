partial class Program
{
  static void ListDictionarys()
  {
      List<string> names = new List<string> {"Ana", "Maria", "danila"}; // solo permite un tipo de dato
      names.Add("John"); // agregar a lista
      Console.WriteLine($"total de nombres: {names.Count}"); // se usa count con list en arrays es .lenght
      foreach (var name in names)
      {
          Console.WriteLine(name);
      }

      names.Remove("Ana");
      bool isContains = names.Contains("Ana");
      Console.WriteLine($"Se encuentra Ana en la lista?: {isContains}");
      
      //dictionarys - decir que tipo de dato es la clave y vallor entre <>

      Dictionary<int, string> students = new Dictionary<int, string>
      {
          { 1, "Ana" }, // key = value
          { 2, "Maria" },
          { 3, "Elena" }
      };
      Console.WriteLine($"estudiante 1: {students[1]}"); // buscar por ID o sea key
      foreach (var student in students)
      {
          Console.WriteLine($"ID: {student.Key}, Name: {student.Value}"); // .key para pedirle la llave solamente - value para el valor (name)
          // studen sin .key o lo otro, recorre todo el diccionario.
      }
  }    
}