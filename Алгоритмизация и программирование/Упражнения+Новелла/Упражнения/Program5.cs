using System;

public class zadanie5
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите сумму вклада:");
        double sum = Convert.ToDouble(Console.ReadLine());
        double percent; 

        if (sum < 100)
        {
            percent = 0.05; 
        }
        else if (sum >= 100 && sum <= 200)
        {
            percent = 0.07;
        }
        else 
        {
            percent = 0.10; 
        }

        double finalSumWithInterest = sum + (sum * percent);

        double bonus = 15.0;
        double finalSumWithBonus = finalSumWithInterest + bonus;

        Console.WriteLine($"Итоговая сумма с процентами и бонусами: {finalSumWithBonus}");

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}