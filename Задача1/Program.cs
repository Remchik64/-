using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число N: ");
        int N = int.Parse(Console.ReadLine());
        PrintNaturalNumbers(N);
    }

    static void PrintNaturalNumbers(int N)
    {
        if (N >= 1)
        {
            Console.Write(N);
            Console.Write(", ");
            PrintNaturalNumbers(N - 1);
        }
    }
}
