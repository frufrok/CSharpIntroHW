// Напишите программу для работы с матрицей целых чисел.

// Реализуйте класс MatrixOperations, который содержит 
// следующие статические методы:

// PrintMatrix(int[,] matrix): Метод для вывода матрицы на экран.
// Он принимает на вход двумерный массив целых чисел matrix
// и выводит его элементы в виде таблицы.

// SortRowsDescending(int[,] matrix): Метод для сортировки 
// строк матрицы по убыванию. Он принимает на вход двумерный массив 
// целых чисел matrix и сортирует каждую строку матрицы так, 
// чтобы элементы в каждой строке шли по убыванию.

// Аргументы, передаваемые в метод/функцию:
// '9, 1, 7; 1, 2, 3; 4, 5, 6'

// На выходе

// Исходная матрица:
// 9   1   7
// 1   2   3
// 4   5   6

// Матрица с упорядоченными по убыванию строками:
// 9   7   1
// 3   2   1
// 6   5   4

using System;

public class Answer
{
    public static void PrintMatrix(int[,] matrix)
    {
        // Введите свое решение ниже
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
    }


    public static void SortRowsDescending(int[,] matrix)
    {
        // Введите свое решение ниже
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i<rows; i++)
        {
            for(int j = 0; j<cols;j++)
            {
                for (int k = j+1; k<cols; k++)
                {
                    if (matrix[i,j] < matrix[i,k])
                    {
                        int temp = matrix[i, k];
                        matrix[i, k] = matrix[i, j];
                        matrix[i, j] = temp;
                    }
                }
            }
        }
    }

    // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;
        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,] {
                {5, 2, 9},
                {8, 1, 4},
                {6, 7, 3}
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                if (elements.Length != matrix.GetLength(1))
                {
                    Console.WriteLine($"Ошибка: Неправильное количество элементов в строке {i + 1}.");
                    return;
                }
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        SortRowsDescending(matrix);

        Console.WriteLine("\nМатрица с упорядоченными по убыванию строками:");
        PrintMatrix(matrix);
    }
}