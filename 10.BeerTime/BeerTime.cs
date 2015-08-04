using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        Console.Write("Enter a time in format hh:mm tt: ");
        string input = Console.ReadLine();
        DateTime time;
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("3:00 AM");
        if (DateTime.TryParse(input, out time))
        {
            if ((time >= startTime) || (time < endTime))
            {
                Console.WriteLine("Beer time");
            }
            else
            {
                Console.WriteLine("Non-beer time");
            }
        }
        else
        {
            Console.WriteLine("Invalid time");
        }

    }
}
