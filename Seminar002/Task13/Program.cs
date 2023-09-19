/*
Задача 13: Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что третьей
цифры нет.
*/

// Метод определяет сколько десятичных разрядов в числе
int Digits(int num)
{
    if (num < 0) num *= -1;
    int result = 0;
    while(num>0)
    {
        result++;
        num /= 10;
    }
    return result;
}

// Метод определяет третью цифру заданного числа или выводит "-1".
int ThirdDigit(int num)
{
    if (num < 0) num *= -1;
    int digs = Digits(num);
    if (digs < 3) return -1;
    for (int i = 0; i < digs - 3; i++) { num /= 10; }
    return (num % 10);
}

// Запрашиваем число
Console.WriteLine("Input integer number:");
int number = Convert.ToInt32(Console.ReadLine());

// Вычисляем результат
int result = ThirdDigit(number);

// Выводим сообщения
if (result < 0) Console.WriteLine($"There is no third digit in {number}.");
else Console.WriteLine(result);