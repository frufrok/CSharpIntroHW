/*
Метод IsPalindrome принимает на вход пятизначное число
number и проверяет, является ли оно палиндромом.
Метод проверяет, является ли число пятизначным, в противном случае
 - выводит "Число не пятизначное" и "False" в следующей строке.
Для остальных чисел возвращает True или False.

14212   ->  False
12821   ->  True
234322  ->  Число не пятизначное
            False
*/


bool IsPalindrome(int num)
{
    if (num<10000 || num >= 100000)
    {
        Console.WriteLine("Число не пятизначное");
        return false;
    }
    int rev = 0;
    int temp = num;
    while(temp % 10 > 0)
    {
        rev *= 10;
        rev += temp % 10;
        temp /= 10;
    }
    if (rev == num) return true;
    else return false;
}

Console.WriteLine(IsPalindrome(65432345));
Console.WriteLine(IsPalindrome(12321));
Console.WriteLine(IsPalindrome(12345));

