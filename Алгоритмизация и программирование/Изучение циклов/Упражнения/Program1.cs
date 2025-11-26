using System;

public class zadanie1

{
    public static void Main(string[] args)
    {
        Console.Write("Введите сумму вклада: ");
        decimal deposit = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Введите количество месяцев: ");
        int months = int.Parse(Console.ReadLine()); 

        decimal procent = 0.07m; 

        decimal final = deposit;

        for (int i = 0; i < months; i++)
        {
           
            final = final * (1 + procent);
        }

        Console.WriteLine($"\nЧерез {months} месяцев сумма вклада составит: {final:C}");

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
