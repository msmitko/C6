using System;

class Task10
{
    static void Main()
    {
        Console.Write("Enter N: (N < 20) ");
        int n = Int32.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j <= i; j++)
            {
                Console.Write("{0} ", j);
            }
            Console.WriteLine();
        }
    }
}

