partial class Program
{
    static void Methods()
    {
        Car newCar = new Car();
        newCar.Model = "BMW";
        newCar.Year = 1997;
        WriteLine(newCar.ShowInfo());
        newCar.ChangeModel("Audy");
        WriteLine(newCar.ShowInfo());
        Car.GeneralInfo();
    }
}

class Car
{
   public string? Model { get; set; }
   public int? Year { get; set; }
   
   //metodo para cambiar el modelo
   public void ChangeModel(string newModel) // insert new model
   {
       Model = newModel; // toma y actualiza el model por newModel
   }
   // muestra info
   public string ShowInfo()
   {
       return $"Car: {Model}, Year: {Year}";
   }
   // sobrecarga de metodo, dos metodos con el mismo nombre pero diferentes funcionalidades
   public void ShowMessage(string message) => WriteLine(message);

   public static void GeneralInfo() => WriteLine("The car is a balbalablaa");
}