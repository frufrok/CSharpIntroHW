/*
Задача 2: Напишите программу, которая на вход
принимает два числа и  выдаёт, какое число большее, а
какое меньшее.
*/
try
{
    Console.WriteLine("Программа выдает максимальное из двух чисел.");
    Console.Write("Введите целое число: a=");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите целое число: b=");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Максимальное значение: {Math.Max(a,b)}");
}
catch
{
    Console.WriteLine("Что-то пошло не так. Перезапустите программу и проверьте свой ввод.");
}