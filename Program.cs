namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime today = DateTime.Now;
            Console.WriteLine($"{today,40:MMMM dd, yyyy}");
            Console.WriteLine($"{today:yyyy.MM.dd}");
            Console.WriteLine($"Day {today:dd} of {today:MMMM}, {today:yyyy}");
            Console.WriteLine($"Year: {today:yyyy}, Month: {today:MM}, Day: {today:dd}");
            Console.WriteLine($"{today,10:h:mm tt}{today,10:dddd}");
            Console.WriteLine($"h:{today:%h}, m:{today:mm}, s:{today:ss}");
            Console.WriteLine($"{today:yyyy.MM.dd.h.mm.ss}");

            var pi = Math.PI;
            Console.WriteLine($"{pi:c}");
            Console.WriteLine($"{pi,10:f3}");
        }
    }
}