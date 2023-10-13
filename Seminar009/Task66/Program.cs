// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

int SumOfNumbersBetween(int M, int N)
{
    if (M < N) { return M + SumOfNumbersBetween(M + 1, N); }
    else if (M > N) { return M + SumOfNumbersBetween(M - 1, N); }
    else { return N; }
}

Console.WriteLine("Введите целое число M=");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число N=");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма всех чисел в промежутке от {M} до {N} равна {SumOfNumbersBetween(M,N)}");