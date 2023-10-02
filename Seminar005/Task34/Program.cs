// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234]-> 2

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

int EvenCount(int[] array)
{
    int size = array.Length;
    int result = 0;
    for (int i = 0; i < size; i++) if (array[i] % 2 == 0) result++;
    return result;
}

Random r = new Random();
int size = r.Next(1, 11);
int[] array = RandomArray(size, 100, 999);
ShowArray(array, $"Считаем количество чётных чисел в массиве:", ", ");
Console.WriteLine($"Чётных чисел в массиве: {EvenCount(array)}.");