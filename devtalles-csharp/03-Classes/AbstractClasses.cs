partial class Program
{
    public static void AbstractClass()
    {
        // tipo clase abstracta, y luego el objeto que queremos crear que usan esa clase abstracta
        HomeAppliance myWasher = new WashingMachine{Brand = "Samsung"};
    }
}
// palabra reservada abstract
abstract class HomeAppliance
{
    public string? Brand { get; set; }
    
    public abstract void TurnOn();

    public void ShowInfo()
    {
        WriteLine($"the brand is {Brand}");
    }
}

class WashingMachine : HomeAppliance
{
    public override void TurnOn()
    {
       WriteLine("Initialize cycle washing"); 
    }
}

class MicroWave : HomeAppliance
{
    public override void TurnOn()
    {
        WriteLine("Initialize MicroWave"); 
    }
}