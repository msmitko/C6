using System;

class Task15
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int n = Int32.Parse(Console.ReadLine());
        string toDecimal = Convert.ToString(Convert.ToInt32(n, 16), 10);
        Console.WriteLine("Result is {0}", toDecimal);
    }
}

