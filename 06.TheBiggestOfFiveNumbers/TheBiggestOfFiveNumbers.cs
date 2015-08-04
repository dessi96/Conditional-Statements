using System;

    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            Console.Write("Enter a number for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter a number for b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter a number for c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Enter a number for d: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Enter a number for e: ");
            double e = double.Parse(Console.ReadLine());

            if (a > b && a > c && a > d && a > e)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c && b > d && b > e)
            {
                Console.WriteLine(b);
            }
            else if (c > a && c > b && c > d && c > e)
            {
                Console.WriteLine(c);
            }
            else if (d > a && d > c && d > b && d > e)
            {
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine(e);
            }
        }
    }
