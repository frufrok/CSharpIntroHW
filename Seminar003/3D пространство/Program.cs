// Метод DistanceBetweenPoints принимает на вход координаты двух точек 
// pointA и pointB в виде массива целых чисел, и возвращает расстояние 
// между ними в 3D пространстве.

double Length(int[] pointA, int[] pointB)
{
    return Math.Sqrt(Math.Pow(pointA[0] - pointB[0], 2) + Math.Pow(pointA[1] - pointB[1], 2) + Math.Pow(pointA[2] - pointB[2], 2));
}

Console.WriteLine(Length(new int[] { 1, 2, 3 }, new int[] { 2, 3, 4 }));
