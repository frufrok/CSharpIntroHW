/*
Задача 4: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.
*/
try
{
    Console.WriteLine("Программа выдает максимальное из трех чисел.");
    int[] nums = new int[3];
    Console.Write("Введите целое число: a=");
    nums[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите целое число: b=");
    nums[1] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите целое число: c=");
    nums[2] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Максимальное значение: {nums.Max()}");
}
catch
{
    Console.WriteLine("Что-то пошло не так. Перезапустите программу и проверьте свой ввод.");
}