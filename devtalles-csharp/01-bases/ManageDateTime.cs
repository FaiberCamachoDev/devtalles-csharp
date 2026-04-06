partial class Program
{
    static void ShowTime()
    {
        DateTime now = DateTime.Now; //ahora
        DateTime today = DateTime.Today; // hoy
        DateTime oneWeekAgo = today.AddDays(-7); // 7 dias atras de ahora (1 semana antes)

        DateTime customDate = new DateTime(2025, 3, 2);

        DayOfWeek weekDay = now.DayOfWeek;
        
        Console.WriteLine($"fecha y hora actual: {now} ");
        Console.WriteLine($"fecha actual: {today.ToString("d")}");
        Console.WriteLine($"hace una semana atras: {oneWeekAgo.ToString("d")}");
        Console.WriteLine($"custom date: {customDate.ToString("d")}");
        Console.WriteLine($"custom date: {weekDay}");
    }
}