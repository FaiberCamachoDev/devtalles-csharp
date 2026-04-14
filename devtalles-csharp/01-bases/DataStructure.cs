// clases - struct - records

partial class Program
{                           
    static void DataStructure()
    {
        //para poder usar la clase se debe instanciar (o sea hacer el proceso de crearlo con new etc etc.)
        User pedro = new User { Name = "pedro", Age = 33 };
        pedro.Greet();
        Point punto = new Point { X=2, Y=4};
        Console.WriteLine($"punto x: {punto.X} y: {punto.Y}");
        CellPhone cell = new CellPhone("Iphone", 2024);
        Console.WriteLine(cell);
    }
}


//creacion de clase user - usar para objetos mas complejos 
class User
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public void Greet()
    {
        Console.WriteLine($"hola soy el usuario {Name} y tengo {Age} anos");
    }
}

// struct - usar para datos mas ligeros
struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
    
}
//record - usar para datos inmutables
record CellPhone(string Model, int Year);