partial class Program
{
    static void Arrays()
    {
        int[] numbers = new int[5]; // aqui le digo crear un array con 5 indices (6 elementos dentro)
        numbers[0] = 1; // primer indice, insertar numero 1
        numbers[1] = 3; // segundo indice, insertar numero 2...
        
        // inicializacion directa
        int[] numbersArray = [10, 15, 20, 25, 30];
        
        //indices 
        Console.WriteLine(numbersArray[0]);
        Console.WriteLine(numbersArray[2]); // obtener 3 elemento
        Console.WriteLine(numbersArray.Length);
        
        //desde el final del arreglo ^
        Console.WriteLine(numbersArray[^1]);
        
        //rangos para obtener subarreglos
        int[] firstThree = numbersArray[..3]; // primeros tres
        int[] fromIndexTwo = numbersArray[2..];
        Console.WriteLine(firstThree);
        Console.WriteLine(fromIndexTwo); //desde el indice dos en adelante
        foreach (var number in firstThree)
        {
            Console.WriteLine(number);
        }

        foreach (var number2 in fromIndexTwo )
        {
            Console.WriteLine(number2);
        }
        
    }
}