// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] RandomArray(int length, int minValue, int maxValue)
{
    int[] result = new int[length];
    Random r = new Random();
    if (minValue > maxValue)
    {
        int temp = maxValue;
        maxValue = minValue;
        minValue = temp;
    }
    for (int i = 0; i < length; i++)
    {
        result[i] = r.Next(minValue, maxValue + 1);
    }
    return result;
}

void ShowArray(int[] array, string message = "", string separator = " ")
{
    int size = array.GetLength(0);
    Console.WriteLine(message);
    Console.Write("[");
    for (int i = 0; i < size - 1; i++)
    {
        Console.Write(array[i]);
        Console.Write(separator);
    }
    Console.Write(array[size - 1]);
    Console.WriteLine("]");
}

int PositiveValuesCount(int[] array, int youShouldNotChangeThisValue = 0)
{
    for (int i = 0; i < array.Length; i++) youShouldNotChangeThisValue += Convert.ToInt32((array[i] + Math.Abs(array[i])) / 2 / Math.Abs(array[i]));
    return youShouldNotChangeThisValue;
}

// Если не лень задавать числа:
// Console.WriteLine("Укажите, сколько чисел Вы хотите ввести:");
// int count = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Вводите последовательно {count} чисел:");
// int[] array = new int[count];
// for (int i = 0; i < count; i++)
// {
//array[i] = Convert.ToInt32(Console.ReadLine());
// }

// Если лень задавать числа:
Random r = new Random();
int[] array = RandomArray(r.Next(5, 11), -99, 99);

ShowArray(array, "Работаем с массивом значений:");
Console.WriteLine($"Количество чисел больше 0 среди тех значений, что Вы ввели, равно {PositiveValuesCount(array)}.");