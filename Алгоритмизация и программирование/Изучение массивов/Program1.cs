using System;

class Program
{
    static void Main()
    {
        int[,,] mas = {
            { { 1, 2 }, { 3, 4 } },
            { { 4, 5 }, { 6, 7 } },
            { { 7, 8 }, { 9, 10 } },
            { { 10, 11 }, { 12, 13 } }
        };

        string result = "{";

        for (int i = 0; i < mas.GetLength(0); i++)
        {
            result += "{";

            for (int j = 0; j < mas.GetLength(1); j++)
            {
                result += "{";

                for (int k = 0; k < mas.GetLength(2); k++)
                {
                    result += mas[i, j, k];

                    if (k < mas.GetLength(2) - 1)
                        result += " , ";
                }

                result += "}";

                if (j < mas.GetLength(1) - 1)
                    result += " , ";
            }

            result += "}";

            if (i < mas.GetLength(0) - 1)
                result += " , ";
        }

        result += "}";
        Console.WriteLine(result);
    }
}