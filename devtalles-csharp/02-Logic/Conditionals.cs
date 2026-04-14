partial class Program
{ 
    static void Conditionals()
    {
        int? age = 19;
        if (true)
        {
            WriteLine("print");
        } // misma logica que java
        // if ternario
        string msg = age > 18 ? "ur adult fck ye" : "ur minor oh no";
        WriteLine($"«{msg}»");
        
        //multiple conditions
        //mismo camino de if > elfse if > else
        
        // switch
        int? Day = null ;
        // Switch con expresiones - el day es el definido e inicializado arriba mismo que switch(day)
        String dayMsg = Day switch
        {
            1 => "lunes",
            2 => "Mrcles",
            3 => "Jueves",
            _ => "other"
        };
        WriteLine(dayMsg);
    }
}