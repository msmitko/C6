using System;

class Task9
{
    static void Main()
    {
        int sum = 1, temp = 1;
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            temp *= i / x;
            sum += temp;
        }

        Console.WriteLine("Result is {0}", sum);
    }
}

