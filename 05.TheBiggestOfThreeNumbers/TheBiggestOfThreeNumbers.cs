using System;

    class TheBiggestOfThreeNumbers
    {
        static void Main()
        {
            Console.Write("Ënter a number for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ënter a number for b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ënter a number for c: ");
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
