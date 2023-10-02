// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12]-> 19
// [-4, -6, 89, 6]-> 0

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

int OddIndexElementsSum(int[] array)
{
    int result = 0;
    int size = array.Length;
    for (int i = 1; i < size; i+=2) result += array[i];
    return result;
}

Random r = new Random();
int size = r.Next(1, 11);
int[] array = RandomArray(size, -99, 99);
ShowArray(array, "Считаем сумму элементов, стоящих на нечётных позициях в массиве:", ", ");
Console.WriteLine($"Сумма равна {OddIndexElementsSum(array)}.");