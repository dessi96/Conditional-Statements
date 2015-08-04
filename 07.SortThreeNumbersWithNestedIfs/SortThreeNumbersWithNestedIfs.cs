using System;

    class SortThreeNumbersWithNestedIfs
    {
        static void Main()
        {
            Console.Write("Enter a number for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter a number for b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter a number for c: ");
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine(a + " " + b + " " + c);
                }
                else
                {
                    Console.WriteLine(a + " " + c + " " + b);
                }
                
            }
            if (b > a && b > c)
            {
                 if (a > c)
                {
                    Console.WriteLine(b + " " + a + " " + c);
                }
                else
                {
                    Console.WriteLine(b + " " + c + " " + a);
                }
            }
            if (c > a && c > b)
            {
                if (a > b)
                {
                    Console.WriteLine(c + " " + a + " " + b);
                }
                else 
                {
                    Console.WriteLine(c + " " + b + " " + a);
                }
            }
            if (a == b && b == c)
            {
                Console.WriteLine(c + " " + a + " " + b);
            }
        }
    }

