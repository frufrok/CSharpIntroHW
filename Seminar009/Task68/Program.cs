// Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29

int Ackermann(int m, int n)
{
    if (m == 0) { return n + 1; }
    else
    {
        if (n==0) { return Ackermann(m - 1, 1); }
        else { return Ackermann(m - 1, Ackermann(m, n - 1)); }
    }
}

// Выводит матрицу в консоль
void ShowMatrix(int[,] matrix, string message="")
{
    Console.WriteLine(message);
    int rowsCount = matrix.GetLength(0);
    int colsCount = matrix.GetLength(1);
    Console.Write("\t");
    for (int j = 0; j < colsCount; j++)
    {
        Console.Write($"{j}\t");
    }
    Console.WriteLine();
    Console.WriteLine();
    for (int i = 0; i < rowsCount; i++)
    {
        Console.Write($"{i}:     ");
        for (int j = 0; j<colsCount; j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите целое неотрицательное число m=");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое неотрицательное число n=");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0) { Console.WriteLine($"Вы ввели отрицательное значение m, расчет выполняем для m = {m *= -1}."); }
if (n < 0) { Console.WriteLine($"Вы ввели отрицательное значение n, расчет выполняем для n = {n *= -1}."); }

Console.WriteLine($"Значение функции Аккермана: A({m},{n})={Ackermann(m,n)}.");

int rows = 11;
int cols = 4;
int[,] ValuesTable = new int[rows, cols];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        ValuesTable[i, j] = Ackermann(j, i);
    }
}

ShowMatrix(ValuesTable, "Таблица значений функции Аккермана (m увеличивается по столбцам):");