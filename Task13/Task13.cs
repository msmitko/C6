using System;

class Task13
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        int n = int.Parse(Console.ReadLine());
        string toDecimal = Convert.ToString(Convert.ToInt32(n, 2), 10);
        Console.WriteLine("Result is {0}", toDecimal);
    }
}

