// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// Внутри класса Answer напишите метод CreateRandomMatrix,
// который принимал бы числа m и n (размерность массива),
// а также minLimitRandom и maxLimitRandom, которые указывают
// на минимальную и максимальную границы случайных чисел.

// Также, задайте метод PrintArray, который выводил бы массив на экран.

// Для вывода матрица используйте интерполяцию строк для форматирования
// числа matrix[i, j] с двумя знаками после запятой (f2) и добавления
// символа табуляции (\t) после каждого элемента матрицы. Таким образом,
// каждый элемент матрицы будет разделен символом табуляции при выводе.

// m = 3, n = 4, minLimitRandom = -10, maxLimitRandom = 10

// 0,5      7       -2     -0,2
// 1        -3,3    8      -9,9
// 8        7,8     -7,1    9

using System;

public class Answer
{
    public static double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
    {
        // Введите свое решение ниже
        Random r = new Random();
        double[,] result = new double[m, n];
        for (int i = 0; i< m; i++)
        {
            for (int j = 0; j<n; j++)
            {
                result[i, j] = minLimitRandom + r.NextDouble() * (maxLimitRandom - minLimitRandom);
            }
        }
        return result;
    }

    public static void PrintArray(double[,] matrix)
    {
        // Введите свое решение ниже
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i<rows; i++)
        {
            for (int j = 0; j<cols; j++)
            {
                Console.Write($"{matrix[i, j]:F2}\t");
            }
            Console.WriteLine();
        }
    }

    // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int m, n, minLimitRandom, maxLimitRandom;

        if (args.Length >= 4)
        {
            m = int.Parse(args[0]);
            n = int.Parse(args[1]);
            minLimitRandom = int.Parse(args[2]);
            maxLimitRandom = int.Parse(args[3]);

            double[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);

            // Выберем случайные индексы трех элементов матрицы array
            int row1 = new Random().Next(0, m);
            int col1 = new Random().Next(0, n);
            int row2 = new Random().Next(0, m);
            int col2 = new Random().Next(0, n);
            int row3 = new Random().Next(0, m);
            int col3 = new Random().Next(0, n);

            // Проверяем, являются ли выбранные элементы дробными числами
            bool isFractional1 = (array[row1, col1] % 1) != 0;
            bool isFractional2 = (array[row2, col2] % 1) != 0;
            bool isFractional3 = (array[row3, col3] % 1) != 0;

            // Если два из трех элементов не являются дробными числами, то бросаем исключение
            if ((isFractional1 && isFractional2) || (isFractional1 && isFractional3) || (isFractional2 && isFractional3))
            {
                Console.WriteLine("Все ок!");
            }
            else
            {
                throw new Exception("Выбранные элементы не содержат по крайней мере два дробных числа.");
            }
        }
        else
        {
            m = 3;
            n = 4;
            minLimitRandom = -10;
            maxLimitRandom = 10;

            double[,] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
            PrintArray(result);
        }
    }
}