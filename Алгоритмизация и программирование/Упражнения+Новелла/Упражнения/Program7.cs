using System;

public class zadanie7
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите номер операции:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.Write("Ваш выбор: ");

        string operation = Console.ReadLine();

        double result = 0; 

        switch (operation)
        {
            case "1":
                result = a + b;
                Console.WriteLine($"Результат сложения = {result}");
                break; 
            case "2":
                result = a - b;
                Console.WriteLine($"Результат вычитания = {result}");
                break;
            case "3":
                result = a * b;
                Console.WriteLine($"Результат умножения = {result}");
                break;
            default:
                Console.WriteLine("ошибка введите числа 1 2 или 3");
                break; 
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}