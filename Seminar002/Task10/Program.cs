// Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа

// Метод выдает вторую цифру трёхзначного числа или "-1" в случае ошибки ввода.
int SecondDigit(int number)
{
    if (number < 0) number *= -1;
    if (100 <= number && number < 1000) return (number - (number / 100) * 100) / 10;
    else return -1;
}

// Запрашиваем число.
Console.WriteLine("Input integer three digits number:");
int num = Convert.ToInt32(Console.ReadLine());

// Определяем результат.
int result = SecondDigit(num);

// Выводим сообщения.
if (result >= 0) Console.WriteLine($"The second digit of your three digit number is {result}");
else Console.WriteLine($"Bad input. Try again.");