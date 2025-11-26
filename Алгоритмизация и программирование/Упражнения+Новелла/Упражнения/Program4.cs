using System;

public class zadanie4
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

        double finalSum = sum + (sum * percent); 

        Console.WriteLine($"Итоговая сумма: {finalSum}"); 
    }
}