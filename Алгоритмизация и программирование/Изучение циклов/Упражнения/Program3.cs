using System;

public class zadanie3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Таблица умножения ---");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                int result = i * j;

                Console.Write($"{i,3} x {j,2} = {result,4} | ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}