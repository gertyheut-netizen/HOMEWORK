using System;

namespace ConsoleApp10
{
    internal class Program
    {
        static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static bool vsBot = true;
        static int currentPlayer = 1; 

        static void DrawBoard()
        {
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("-----------");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("-----------");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
        }

        static bool CheckForWin()
        {
            return (board[0] == board[1] && board[1] == board[2]) ||
                   (board[3] == board[4] && board[4] == board[5]) ||
                   (board[6] == board[7] && board[7] == board[8]) ||
                   (board[0] == board[3] && board[3] == board[6]) ||
                   (board[1] == board[4] && board[4] == board[7]) ||
                   (board[2] == board[5] && board[5] == board[8]) ||
                   (board[0] == board[4] && board[4] == board[8]) ||
                   (board[2] == board[4] && board[4] == board[6]);
        }

        static bool CheckForDraw()
        {
            foreach (char cell in board)
            {
                if (cell != 'X' && cell != 'O')
                    return false;
            }
            return true;
        }
        static int GetBotMove()
        {
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] != 'X' && board[i] != 'O')
                    return i;
            }
            return -1;
        }

        static void Main()
        {
            int choice;
            bool validInput;
            Console.Write("Играть против бота? (да/нет): ");
            var botAnswer = Console.ReadLine();
            vsBot = botAnswer?.Trim().ToLower().StartsWith("да") ?? false;
            currentPlayer = 1;

            do
            {
                Console.Clear();
                DrawBoard();

                if (vsBot && currentPlayer == 2)
                {
                    Console.WriteLine("Ход бота. Нажмите Enter, чтобы продолжить..."); 
                    Console.ReadLine();

                    int botIndex = GetBotMove();
                    if (botIndex >= 0)
                    {
                        board[botIndex] = 'O'; 
                        Console.WriteLine($"Бот выбрал клетку {botIndex + 1}");

                        if (CheckForWin())
                        {
                            Console.Clear();
                            DrawBoard();
                            Console.WriteLine("Победил бот!");
                            break;
                        }

                        if (CheckForDraw())
                        {
                            Console.Clear();
                            DrawBoard();
                            Console.WriteLine("Ничья");
                            break;
                        }

                        currentPlayer = 1;
                    }
                    continue;
                }

                Console.WriteLine($"Игрок {currentPlayer}, введи номер ячейки:");

                validInput = int.TryParse(Console.ReadLine(), out choice) && choice
>= 1 && choice <= 9 && board[choice - 1] != 'X' && board[choice - 1] != 'O';

                if (validInput)
                {
                    board[choice - 1] = (currentPlayer == 1) ? 'X' : 'O';

                    if (CheckForWin())
                    {
                        Console.Clear();
                        DrawBoard();
                        Console.WriteLine($"Победил игрок {currentPlayer}");
                        break;
                    }

                    if (CheckForDraw())
                    {
                        Console.Clear();
                        DrawBoard();
                        Console.WriteLine("Ничья");
                        break;
                    }

                    currentPlayer = (currentPlayer == 1) ? 2 : 1;
                }
                else
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            } while (true);
        }
    }
}