using System;

    class Triangle
    {
        static void Main()
        {
            int ax = int.Parse(Console.ReadLine());
            int ay = int.Parse(Console.ReadLine());
            int bx = int.Parse(Console.ReadLine());
            int by = int.Parse(Console.ReadLine());
            int cx = int.Parse(Console.ReadLine());
            int cy = int.Parse(Console.ReadLine());

            double ab = Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by));
            double ac = Math.Sqrt((ax - cx) * (ax - cx) + (ay - cy) * (ay - cy));
            double bc = Math.Sqrt((bx - cx) * (bx - cx) + (by - cy) * (by - cy));

            bool formATriangle = (ac + bc > ab && ac + ab > bc && ab + bc > ac);

            if (formATriangle == false)
            {
                Console.WriteLine("No");
                Console.WriteLine("{0:F2}", ab);
            }
            else
            {
                Console.WriteLine("Yes");
                double p = (ab + bc + ac) / 2;
                double area = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
                Console.WriteLine("{0:F2}", area);
            }
        }
    }

