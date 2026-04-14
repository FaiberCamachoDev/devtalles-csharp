using System.Globalization; // aspectos relacionados con la localizacion y cultura

partial class Program
{
    static void ConvertStringToDate()
    {
        //definimos la cultura del sistema
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-ES");
        // 
        DateTime birthday = DateTime.Parse("2 marzo 2025");
        WriteLine($"mi fiesta es el {birthday:d}");
    }
}