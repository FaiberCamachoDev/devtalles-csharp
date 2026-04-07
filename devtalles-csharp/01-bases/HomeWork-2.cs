using System.Globalization;
using System.Runtime.InteropServices.JavaScript;

partial class Program
{
    static void DaysUntilNextBirthday()
    {
        Console.WriteLine("Introduce tu fecha de nacimiento(dd/mm/aaaa): ");
        string birthDateString = Console.ReadLine()!; //leyendo input
        //Parsear string de fecha en un formato DateTime de esta forma con los 3 parametros:
        DateTime birthDay = DateTime.ParseExact(birthDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        DateTime currentDate = DateTime.Now.Date;
        DateTime nextBirthday = new DateTime(currentDate.Year, birthDay.Month, birthDay.Day);
        if (nextBirthday < currentDate)
        {
            nextBirthday = nextBirthday.AddYears(1);
        }
        int dayRemaining = (nextBirthday - currentDate).Days;
        Console.WriteLine($"Days remaining for you Birthday: {dayRemaining} ");
    }
}