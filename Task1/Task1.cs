using System;

class Task1
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int length = int.Parse(Console.ReadLine());

        for (int i = 1; i < length; i++)
            Console.WriteLine(i);
    }
}

