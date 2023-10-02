// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Укажите, сколько чисел Вы хотите ввести:");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];

for (int i = 0; i < count; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int PositiveValuesCount(int[] array)
{
    PositiveValuesCount(a)
    if (first < array.)
    if (first < array.Length)
    {
        array[first] > 0 return 1 + PositiveValuesCount(array, first + 1);
    }
}

Console.WriteLine($"Количество чисел больше 0 среди тех значений, что Вы ввели, равно {PositiveValuesCount(array)}");