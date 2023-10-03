// Нужно найти 2 максимальных элемента произвольного массива.
// Примечание автора:
// Использую разные способы решения задачи, сравниваю, нахожу лучший.

using System.Diagnostics;

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

// Донашиваем вещи за старшим братом.
int[] TwoMaxValues1(int[] array)
{
    int count = array.Length;
    if (count <2) 
    {
        Console.WriteLine("В массиве меньше 2 чисел. Попробуйте снова.");
        return new int[0];
    }
    else
    {
        int max1 = array[0];
        int max2 = array[0];
        for (int i = 1; i < count; i++)
        {
            if (array[i] > max1) 
            {
                max2 = max1;
                max1 = array[i];
            }
            else if (array[i] > max2)
            {
                max2 = array[i];
            }
        }
        return new int[] { max1, max2 };
    }
}

// Использование пузырьковой сортировки
void SortArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i<count; i++)
    {
        for (int j = i+1; j < count; j++)
        {
            if (array[i] > array[j])
            {
                int temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }
    }
}
int[] TwoMaxValues2(int[] array)
{
    int count = array.Length;
    if (count < 2)
    {
        Console.WriteLine("В массиве меньше 2 чисел. Попробуйте снова.");
        return new int[0];
    }
    else
    {
        SortArray(array);
        return new int[2] { array[count - 1], array[count - 2] };
    }
}

// Использование встроенной сортировки.
int[] TwoMaxValues3(int[] array)
{
    int count = array.Length;
    if (count < 2)
    {
        Console.WriteLine("В массиве меньше 2 чисел. Попробуйте снова.");
        return new int[0];
    }
    else
    {
        Array.Sort(array);
        return new int[2] { array[count - 1], array[count - 2] };
    }
}

// Использование перестановки максимального в конец (всплытие одного пузырька)
void MoveMaxToTheEnd(int[] array, int indexFromLast = 0)
{
    int count = array.Length - indexFromLast;
    for (int i = 0; i < count; i++)
    {
        if (array[i] > array[count - 1]) 
        {
            int temp = array[i];
            array[i] = array[count - 1];
            array[count - 1] = temp;
        }
    }
}
int[] TwoMaxValues4(int[] array)
{
    int count = array.Length;
    if (count < 2)
    {
        Console.WriteLine("В массиве меньше 2 чисел. Попробуйте снова.");
        return new int[0];
    }
    else
    {
        MoveMaxToTheEnd(array);
        MoveMaxToTheEnd(array, 1);
        return new int[2] { array[count - 1], array[count - 2] };
    }
}

// Ищем лучший из методов.
Stopwatch sw = new Stopwatch();
sw.Start();
int[] hugeArray1 = RandomArray(50000, -1000000, 1000000);
int[] hugeArray2 = RandomArray(50000, -1000000, 1000000);
int[] hugeArray3 = RandomArray(50000, -1000000, 1000000);
Console.WriteLine($"Ушло времени на генерацию массивов: {sw.Elapsed}");
sw.Restart();
ShowArray(TwoMaxValues1(hugeArray1), "Максимальные значения по методу донашивания вещей:");
Console.WriteLine($"Прошло времени: {sw.Elapsed}");
sw.Restart();
ShowArray(TwoMaxValues2(hugeArray1), "Максимальные значения по методу пузырьковой сортировки (первый массив):");
Console.WriteLine($"Прошло времени: {sw.Elapsed}");
sw.Restart();
ShowArray(TwoMaxValues3(hugeArray2), "Максимальные значения по методу сортировки встроенной функцией (второй массив):");
Console.WriteLine($"Прошло времени: {sw.Elapsed}");
sw.Restart();
ShowArray(TwoMaxValues4(hugeArray3), "Максимальные значения по методу перестановки максимального в конец (третий массив):");
Console.WriteLine($"Прошло времени: {sw.Elapsed}");
