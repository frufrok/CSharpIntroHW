// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] CrossPoint(double b1, double k1, double b2, double k2)
{
    if (k1==k2) 
    {
        Console.WriteLine("Прямые параллельны и не пересекаются в Евклидовом пространстве.");
        return new double[0];
    }
    else
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = k1 * x + b1;
        return new double[] { x, y };
    }
}

void ShowArray(double[] array, string message = "", string separator = " ", int digits = 2)
{
    int size = array.GetLength(0);
    Console.WriteLine(message);
    Console.Write("[");
    for (int i = 0; i < size - 1; i++)
    {
        Console.Write(Math.Round(array[i], digits));
        Console.Write(separator);
    }
    Console.Write(Math.Round(array[size - 1], digits));
    Console.WriteLine("]");
}

// Пример из задания:
// int b1 = 2;
// int k1 = 5;
// int b2 = 4;
// int k2 = 9;

// Если лень задавать:
// Random r = new Random();
// int b1 = r.Next(-10,10);
// int k1 = r.Next(-10, 10);
// int b2 = r.Next(-10, 10);
// int k2 = r.Next(-10, 10);

// Если не лень задавать:
Console.WriteLine("Укажите подряд 4 параметра в последовательности: k1, b1, k2, b2");
double k1 = double.Parse(Console.ReadLine()??"0");
double b1 = double.Parse(Console.ReadLine() ?? "0");
double k2 = double.Parse(Console.ReadLine() ?? "0");
double b2 = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Ищем точку пересечения прямых, заданных уравнениями:");
Console.WriteLine($"y = {k1} * x + {b1};");
Console.WriteLine($"y = {k2} * x + {b2}.");

double[] cPoint = CrossPoint(b1, k1, b2, k2);
if (cPoint.Length !=0) ShowArray(cPoint, "Точка пересечения заданных прямых:");