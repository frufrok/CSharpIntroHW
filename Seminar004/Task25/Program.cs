// Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Примечание автора: реализована возможность задавать целую степень B.

double Pow(int A, int B)
{
    if (B < 0)
    {
        B *= -1;
        double result =  1.0 / A;
        for (int i = 1; i<B; i++)
        {
            result /= A;
        }
        return result;
    }
    else if (B == 0) return 1;
    else
    {
        int result = A;
        for (int i = 1; i < B; i++)
        {
            result *= A;
        }
        return result;
    }
}

Console.WriteLine("Введите любое целое число: A=");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите любое целое число: B=");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Результатом возведения числа A в степень B является {Pow(A, B)}");