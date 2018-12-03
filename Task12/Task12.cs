using System;

class Task12
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        string binary = Convert.ToString(n, 2);
        Console.WriteLine("Result is {0}", binary);
    }
}

