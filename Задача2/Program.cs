using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        if (M > N)
        {
            Console.WriteLine("M должно быть меньше или равно N.");
        }
        else
        {
            int sum = CalculateSumOfNaturalNumbers(M, N);
            Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна: {sum}");
        }
    }

    static int CalculateSumOfNaturalNumbers(int start, int end)
    {
        int sum = 0;
        for (int i = start; i <= end; i++)
        {
            sum += i;
        }
        return sum;
    }
}


