using System;

public class zadanie6
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите номер операции:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.Write("Ваш выбор: ");

        string operation = Console.ReadLine();

        switch (operation)
        {
            case "1":
                Console.WriteLine("Вы выбрали: Сложение");
                break; 
            case "2":
                Console.WriteLine("Вы выбрали: Вычитание");
                break; 
            case "3":
                Console.WriteLine("Вы выбрали: Умножение");
                break; 
            default: 
                Console.WriteLine("Ошибка: Операция неопределена. Пожалуйста, выберите 1, 2 или 3.");
                break; 
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}