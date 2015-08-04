using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Ënter a number for a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Ënter a number for b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Ënter a number for c: ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("0");
        }
        else if (a * b * c > 0)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}
