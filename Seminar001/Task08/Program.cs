/*
Задача 8: Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные числа от 1 до N;
*/

try
{
    Console.WriteLine("Программа показывает список чётных чисел от 1 до N.");
    Console.Write("Введите любое целое положительное число N=");
    int N = Convert.ToInt32(Console.ReadLine());
    if (N>1) 
    {
        Console.WriteLine($"Список чётных чисел от 1 до N={N}:");
        for (int i = 2; i<=N; i+=2)
            Console.WriteLine(i);
    }
    else if (N>=0) 
        Console.WriteLine($"Список чётных чисел от 1 до N={N} пуст");
    else 
        Console.WriteLine($"Введённое Вами число N={N} < 0");
}
catch
{
    Console.WriteLine("Что-то пошло не так. Перезапустите программу и проверьте свой ввод.");
}