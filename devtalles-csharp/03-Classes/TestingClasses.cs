partial class Program
{
    static void TestingClass()
    {
        // luego que creamos nuestra clase, creamos la instancia para empezar a construirla
        Vehicle toyota = new Vehicle();
        toyota.Brand = "Toyota";
        toyota.Model = "Corolla";
        toyota.Year = 2021;
        toyota.ShowInfo(); 
        // otra forma de instanciar es...
        Vehicle honda = new Vehicle{Brand = "Honda", Model = "Civic", Year = 2001}; // para inicializar los atributos de una, son con llaves
        honda.ShowInfo();
        Vehicle renault = new Vehicle("Renault", "Duster", 2024); // asi se construye a traves del constructor
        renault.ShowInfo();

    }
}

class Vehicle
{
    // que tiene una clase? propiedades y metodos
    
    // propiedades (atributes)
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int? Year { get; set; }
    // metodos constructores - se usan para crear instancias
    public Vehicle(string? brand, string? model, int? year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }
    // este a diferencia del constructor con los params definidos es que no tiene ninguna regla al armar, el constructor tiene que cumplor ocn los params definidos.
    public Vehicle(){} // este metodo es para poder instanciar la clase sin tener parametros definidos.

    public void ShowInfo()
    {
        WriteLine($"This vehicle is {Brand} {Model} of the year {Year}");
    }
    
}