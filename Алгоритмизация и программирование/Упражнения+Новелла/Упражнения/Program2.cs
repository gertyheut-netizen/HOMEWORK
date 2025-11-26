using System;

public class zadanie3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        int a = int.Parse(Console.ReadLine());

        {
            if (a == 5 || a == 10)
            {
                Console.WriteLine("Число либо равно 5, либо равно 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}