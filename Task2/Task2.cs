using System;

class Task2
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int length = Int32.Parse(Console.ReadLine());

        for (int i = 1; i < length; i++)
        {
            if (i % (3 * 7) != 0) Console.WriteLine(i);
        }
    }
}

