partial class Program
{
    static void Methods()
    {
        // constructor default
         Car car = new Car();
            car.Model = "BMW";
            car.Year = 1997;
        WriteLine(car.ShowInfo());
        // newCar.ChangeModel("Audy");
        // WriteLine(newCar.ShowInfo());
        // Car.GeneralInfo();
        
        // un constructor con parametros
        Car sportCar = new Car("Ferrari", 2026);
        WriteLine(sportCar.ShowInfo());
        
        // sintaxis simplificada
        Car collectionCar = new Car { Model = "cadillac", Year = 2021 };
        WriteLine(collectionCar.ShowInfo());
    }
}

class Car
{
   public string? Model { get; set; }
   public int? Year { get; set; }

   public Car(string? model, int? year) //constructor con parametros
   {
       Model = model;
       Year = year;
   }

   public Car() //constructor por defecto
   {
   }
   
   //destructor (~)
   ~Car()
   {
       WriteLine("Destructor llamada. Recurso liberado");
   }

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