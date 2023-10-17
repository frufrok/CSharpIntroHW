// Реализуйте класс MatrixOperations, который содержит следующие статические методы:

// MultiplyIfPossible(int[,] matrixA, int[,] matrixB): Метод для проверки, возможно
// ли умножения двух матриц matrixA и matrixB. Если число столбцов в матрице matrixA 
// не равно числу строк в матрице matrixB, то выводится сообщение 
// "It is impossible to multiply."
// В противном случае, вызывается метод MatrixMultiplication для умножения матриц, 
// и результат выводится с помощью метода PrintMatrix.

// MatrixMultiplication(int[,] matrixA, int[,] matrixB): Метод для умножения двух 
// матриц matrixA и matrixB. Метод возвращает новую матрицу, которая представляет 
// собой результат умножения матрицы matrixA на матрицу matrixB.

// PrintMatrix(int[,] matrix): Метод для вывода матрицы на консоль.

// Если аргументы не переданы, программа использует матрицы по умолчанию. Если 
// аргументы переданы, программа парсит их в двумерные массивы целых чисел и 
// выполняет умножение матриц.

// Аргументы, передаваемые в метод/функцию:

// '1,2;3,4'

// На выходе:

// Исходная матрица:
// 1   2
// 3   4

// Matrix B:
// 5   6
// 7   8

// Multiplication result:
// 19  22
// 43  50

using System;
public class Answer
{
    public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
    { 
        // Введите свое решение ниже
        //int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int rowsB = matrixB.GetLength(0);
        //int colsB = matrixB.GetLength(1);
        if (colsA == rowsB)
        {
            PrintMatrix(MatrixMultiplication(matrixA, matrixB));
        }
        else
        {
            Console.WriteLine("It is impossible to multiply.");
        }
    }

    public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {  
        // Введите свое решение ниже
        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int rowsB = matrixB.GetLength(0);
        int colsB = matrixB.GetLength(1);
        int operations = Math.Min(colsA, rowsB);
        int[,] result = new int[rowsA, colsB];
        for(int i = 0; i<rowsA; i++)
        {
            for (int j =0; j<colsB; j++)
            {
                for (int k = 0; k<operations; k++)
                {
                    result[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
        return result;
    }

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
    // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;

        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,]
            {
                {5, 2},
                {8, 1}
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

        int[,] matrixB = {
            {5, 6},
            {7, 8}
        };

        Console.WriteLine("\nMatrix B:");
        PrintMatrix(matrixB);

        Console.WriteLine("\nMultiplication result:");

        MultiplyIfPossible(matrix, matrixB);
    }
}
