/*
Задача 15: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
*/

// Метод выдает True если задан номер выходного дня недели.
int IsWeekend(int daynum)
{
    if (daynum < 1) return -1;
    else if (daynum <= 5) return 0;
    else if (daynum <= 7) return 1;
    else return -1;
}

// Запрашиваем день недели:
Console.WriteLine("Input week day number. It must be integer in the [1,7] range:");
int num = Convert.ToInt32(Console.ReadLine());

// Вычисляем результат
int result = IsWeekend(num);

// Выводим сообщение
switch(result)
{
    case -1: Console.WriteLine("Bad week day number. Try again."); break;
    case 0: Console.WriteLine($"Day {num} is not weekend."); break;
    case 1: Console.WriteLine($"Day {num} is weekend."); break;
    default: Console.WriteLine($"Something is wrong with {num}. It is my fault."); break;
}