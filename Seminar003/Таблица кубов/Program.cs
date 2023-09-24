// Метод ShowCube принимает на вход число (N) 
// и выводит таблицу кубов чисел от 1 до N
// (включительно) каждое на новой строке

void ShowCube(int N)
{
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
}

ShowCube(6);