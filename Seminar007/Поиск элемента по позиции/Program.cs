// Внутри класса Answer напишите методы CreateIncreasingMatrix, 
// PrintArray, FindNumberByPosition и PrintCheckIfError.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной 
// размерности, с каждым новым элементом увеличивающимся на определенное 
// число. Метод принимает на вход три числа:
//     n - количество строк матрицы, 
//     m - количество столбцов матрицы,
//     k - число, на которое увеличивается каждый новый элемент
// и возвращает матрицу, удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

// Метод FindNumberByPosition принимает на вход сгенерированную матрицу и числа x и y - 
// позиции элемента в матрице. Если указанные координаты находятся за пределами границ массива, 
// метод должен вернуть массив с нулевым значением. Если координаты находятся в пределах границ, 
// метод должен вернуть массив с двумя значениями: значением числа в указанной позиции, а второй 
// элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.

// Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа 
// x и y - позиции элемента в матрице. Метод должен проверить, был ли найден элемент в матрице
// по указанным координатам (x и y), используя результаты из метода FindNumberByPosition. Если
// такого элемента нет, вывести на экран "There is no such index". Если элемент есть, вывести 
// на экран "The number in [{x}, {y}] is {значение}".

// Пример:

// n = 3;
// m = 4;
// k = 2;
// x = 8;
// y = 3;

// int[,] result = CreateIncreasingMatrix(n, m, k);
// PrintArray(result);
// PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);

/*
1   3   5   7   
9   11  13  15  
17  19  21  23  
There is no such index
*/

// n = 4;
// m = 5;
// k = 3;
// x = 2;
// y = 2;

// int[,] result = CreateIncreasingMatrix(n, m, k);
// PrintArray(result);
// PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);

/*
1   4   7   10  13  
16  19  22  25  28  
31  34  37  40  43  
46  49  52  55  58  
The number in [2, 2] is 19
*/

using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        // Введите свое решение ниже
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i<rows; i++)
        {
            for (int j = 0; j<cols; j++)
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
            for (int j = 0; j< m; j++)
            {
                int posNumber = i * m + j;
                int value = firstValue + k * posNumber;
                result[i, j] = value;
            }
        }
        return result;
    }

    public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
    {
        // Введите свое решение ниже
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int x = rowPosition - 1;
        int y = columnPosition - 1;
        if (x < rows && y < cols) return new int[2] { matrix[x, y], 0 };
        else return new int[2] {0, 1};
    }

    public static void PrintCheckIfError(int[] results, int X, int Y)
    {
        // Введите свое решение ниже
        if (results[1] > 0) Console.WriteLine("There is no such index");
        else Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k, x, y;

        if (args.Length >= 5)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
            x = int.Parse(args[3]);
            y = int.Parse(args[4]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            // n = 3;
            // m = 4;
            // k = 2;
            // x = 2;
            // y = 3;
            n = 4;
            m = 5;
            k = 3;
            x = 2;
            y = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}