// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

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

double[] RandomArrayDouble(int length, double minValue, double maxValue, int digits)
{
    double[] result = new double[length];
    if (digits < 0) digits *= -1;
    int min = Convert.ToInt32(minValue * Math.Pow(10, digits));
    int max = Convert.ToInt32(maxValue * Math.Pow(10, digits));
    int[] temp = RandomArray(length, min, max);
    for(int i = 0; i<length; i++)
    {
        result[i] = temp[i] / Math.Pow(10, digits);
    }
    return result;
}

void ShowArray(double[] array, string message = "", string separator = " ")
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

void SortArray(double[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        for (int j = i + 1; j < size; j++)
        {
            if (array[i] > array[j])
            {
                double temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }
    }
}

double Amplitude(double[] array)
{
    SortArray(array);
    return array.Last() - array.First();
}

Random r = new Random();
int size = r.Next(1, 11);
double[] array = RandomArrayDouble(size, -99.99, 99.99, 2);
ShowArray(array, "Считаем разницу между минимальным и максимальным элементами массива:", "; ");
 Console.WriteLine($"Разность равна {Amplitude(array)}.");