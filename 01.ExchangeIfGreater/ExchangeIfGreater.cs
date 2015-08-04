using System;

    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.Write("Enter a number for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter a number for b: ");
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(b + " " + a);
            }
            else
            {
                Console.WriteLine(a + " " + b);
            }
        }
    }
