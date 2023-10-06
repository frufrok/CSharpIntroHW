// Внутри класса Answer напишите методы CreateIncreasingMatrix, 
// PrintArray, PrintListAvr и FindAverageInColumns.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, 
// с каждым новым элементом увеличивающимся на определенное число. Метод принимает
// на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы,
// k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу,
// удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом
// CreateIncreasingMatrix матрицу.

// Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и
// возвращает одномерный массив типа double. Этот метод вычисляет среднее значение
// чисел в каждом столбце матрицы и сохраняет результаты в виде списка.

// Метод PrintListAvr принимает одномерный массив, возвращенный методом
// FindAverageInColumns и выводит этот список на экран в формате 
// "The averages in columns are: x.x0 x.x0 x.x0 ...",
// где x.x0 - это значения средних значений столбцов, округленные до двух знаков
// после запятой (в дробной части ВСЕГДА должно быть 2 числа через точку,
// см. формат вывода), разделенные знаком табуляции.


// Пример

// n = 3;
// m = 4;
// k = 2;

// int[,] result = CreateIncreasingMatrix(n, m, k);
// PrintArray(result);
// PrintListAvr(FindAverageInColumns(result));

/*
1   3   5   7   
9   11  13  15  
17  19  21  23  
The averages in columns are: 
9.00    11.00   13.00   15.00
*/

using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
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

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        // Введите свое решение ниже
        int[,] result = new int[n, m];
        int firstValue = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                int posNumber = i * m + j;
                int value = firstValue + k * posNumber;
                result[i, j] = value;
            }
        }
        return result;
    }

    static void PrintListAvr(double[] list)
    {
        // Введите свое решение ниже
        Console.WriteLine("The averages in columns are: ");
        int count = list.Length;
        for (int i = 0; i< count; i++)
        {
            Console.Write($"{list[i]:F2}\t");
        }
        Console.WriteLine();
    }

    static double[] FindAverageInColumns(int[,] matrix)
    {
        // Введите свое решение ниже
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[] result = new double[cols];
        for (int j = 0; j<cols; j++)
        {
            for (int i = 0; i<rows; i++)
            {
                result[j] += matrix[i, j];
            }
            result[j] /= rows;
        }
        return result;
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k;

        if (args.Length >= 3)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 3;
            m = 4;
            k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}