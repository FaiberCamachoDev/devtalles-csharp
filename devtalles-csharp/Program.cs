
using System.Runtime.InteropServices.JavaScript;

partial class Program
{
    static void Main(string[] args)
    {
        ListDictionarys();
        Console.Write("Insert your name: ");
        string? name = Console.ReadLine();
        bool exit = false;
        string useName = string.IsNullOrEmpty(name) ?  "User" : name;
        do
        {
            Console.Clear();
            Console.WriteLine("««Center of technical train»»");
            Console.WriteLine(@$"Welcome {useName.ToUpper()}!
Nivel 1: Suma y validación numérica
Nivel 2: Cálculo y condicionales
Nivel 3: Manipulación de Cadenas
Nivel 4: Operaciones Lógicas (Calculadora)
Nivel 5: Análisis Numérico (Listas de enteros)
Nivel 6: Gestión de Tareas (Listas de cadenas)
Nivel 7: Arreglos y Búsqueda
Nivel 8: Programación Orientada a Objetos (Clases)
Nivel 9: CRUD de Objetos (Listas de objetos)
10: Salir
Seleccione un nivel para iniciar: ");
            if (int.TryParse(Console.ReadLine(), out int option))
            {
                switch (option)
                {
                    case 1:
                        Lvl1();
                        PressEnterTo();
                        break;
                    case 2:
                        Lvl2();
                        PressEnterTo();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        exit = true;
                        Console.WriteLine("Closing App...");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        PressEnterTo();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Insert a valid option.");
                PressEnterTo();
            }
        } while (!exit);
        
    }
    static void PressEnterTo()
    {
        Console.WriteLine("\nPress Enter to continue");
        Console.ReadKey();
    }

    static int IntValidator()
    {
        bool isValid;
        int number;
        do
        {
            string? input = Console.ReadLine();
            isValid= int.TryParse(input, out number);
        
            if (!isValid || number < 0)
            {
                Console.WriteLine("Invalid type of number, insert a valid format.");
                PressEnterTo();
            }
        } while (!isValid);
        
        return number;

    }
}

