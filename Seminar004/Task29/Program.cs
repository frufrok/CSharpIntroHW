// Напишите программу, которая задаёт массив из
// произвольного количества случайных элементов и выводит их на экран.
// [1, 2, 5, 7, 19]
// [6, 1, 33]

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

void ShowArray(int[] array, string message="", string separator = " ")
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

Random r = new Random();
int size = r.Next(1, 11);
ShowArray(RandomArray(size, 0, 100), $"Выводим массив из {size} произвольно заданных чисел от 0 до 100");