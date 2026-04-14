partial class Program
{
    static void Properties()
    {
        Animal animal = new Animal("Bosque");
        animal.Specie = "Lobo";
        animal.Age = 5;
        WriteLine($@"Donde vive: {animal.Habitat}
Specie: {animal.Specie}
age: {animal.Age}
category: {animal.Category}");
    }
}

class Animal
{
    public string? Specie { get; set; } = "Unkown"; // valor por defecto asi se asigna - propiedades automaticas
    public string? Category { get; set; } = "Vertebrados";
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age must be greater than 0");
            }
            age = value; 
        }
    }
    public string? Habitat { get; }

    public Animal(string? habitat)
    {
        Habitat = habitat;
    }
}