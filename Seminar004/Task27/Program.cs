// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfDigits(int num)
{
    if (num<0) { num *= -1; }
    int result = num % 10;
    while(num / 10 > 0)
    {
        num /= 10;
        result += num % 10;
    }
    return result;
}

Console.Write("Введите любое целое число A=");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {A} равна {SumOfDigits(A)}.");