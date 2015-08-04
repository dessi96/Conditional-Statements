using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
       Console.Write("Please choose a type (1 for int, 2 for double, 3 for string): ");
       string type = Console.ReadLine();

       switch (type)
       {
           case "1": 
               Console.Write("Please enter a int: ");
               int input = int.Parse(Console.ReadLine());
               Console.WriteLine(input + 1);
               break;
           case "2":
               Console.Write("Please enter a double: ");
               double input02 = double.Parse(Console.ReadLine());
               Console.WriteLine(input02 + 1);
               break;
           case "3": 
               Console.Write("Please enter a string: ");
               string input03 = Console.ReadLine();
               Console.WriteLine(input03 + "*");
               break;
           default: 
               Console.WriteLine("Invalid input");
               break;
       }
    }
}