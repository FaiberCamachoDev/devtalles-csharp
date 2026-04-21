partial class Program
{
    public static void Inheritante()
    {
        HogwarStudent student = new HogwarStudent() { House = "Griffyndor", Name = "Harry Potter"};
        HogwarTeacher teacher = new HogwarTeacher() { Name = "Severus", Subject = "Black wiwi"};
        student.Greet();
        student.ShowHouse();
        teacher.Greet();
        teacher.ShowSubject();
    }
    
    
}
class Character
{
    public string? Name { get; set; }

    public virtual void Greet()
    {
        WriteLine($"Hi, im {Name}");
    }
}
class HogwarStudent : Character // Hogwarts hereda de character
{
    public string? House { get; set; }

    public void ShowHouse()
    {
        WriteLine($"Im in the house {House} of Hogwarts");
    }
        
}
class HogwarTeacher : Character // Hogwarts hereda de character
{
    public string? Subject { get; set; }

    public void ShowSubject()
    {
        WriteLine($"I teach {Subject} in Hogwarts");
    }
        
}