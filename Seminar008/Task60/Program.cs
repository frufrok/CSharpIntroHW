// Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая
// будет построчно выводить массив, добавляя индексы каждого
// элемента
// Массив размером 2x2x2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Методы в соответствии с заданим генерирут НЕ ПОВТОРЯЮЩИЕСЯ значения.
int[,,] NoRepeats3DArray(int rows, int cols, int floors, int minValue = 0, int maxValue = 100)
{
    if (rows<=0 || cols<=0 || floors<=0)
    {
        Console.WriteLine($"One of the dimensions {rows}, {cols}, {floors} is equal to or less then zero. NoRepeats3DArray will return zero-length array.");
        return new int[0, 0, 0];
    }
    else
    {
        int count = rows * cols * floors;
        int[] noRepeatsArray = NoRepeatsArray(count, minValue, maxValue);
        if (noRepeatsArray.Length<=0)
        {
            Console.WriteLine("NoRepeatsArray returned zero length array. NoRepeats3DArray also will return zero-length array.");
            return new int[0, 0, 0];
        }
        else
        {
            int[,,] result = new int[rows, cols, floors];
            int l = 0;
            for (int k = 0; k < floors; k++)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        result[i, j, k] = noRepeatsArray[l];
                        l++;
                    }
                }
            }
            return result;
        }
    }
}

int[] NoRepeatsArray(int count, int minValue = 0, int maxValue = 100)
{
    if (count <= 0)
    {
        Console.WriteLine($"Count {count} is less then or equal to zero. NoRepeatsArray will return zero-length array.");
        return new int[0];
    }   
    else
    {
        if (maxValue < minValue)
        {
            int temp = minValue;
            minValue = maxValue;
            maxValue = temp;
        }
        int range = maxValue - minValue + 1;
        if (range < count)
        {
            Console.WriteLine($"Range {range} is not enough to generate {count} no repeats values. NoRepeatsArray will return zero-length array.");
            return new int[0];
        }
        else
        {
            int[] result = new int[count];
            Random r = new Random();
            for (int i = 0; i < count; i++)
            {
                bool done = false;
                while (!done)
                {
                    bool exists = false;
                    int newValue = r.Next(minValue, maxValue + 1);
                    for (int j = 0; j < i; j++)
                    {
                        if (result[j] == newValue) exists = true;
                    }
                    if (!exists)
                    {
                        result[i] = newValue;
                        done = true;
                    }
                }
            }
            return result;
        }
    }
}

void Show3DArray(int[,,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int floors = array.GetLength(2);

    for(int k = 0; k<floors;k++)
    {
        Console.WriteLine($"Floor {k}:");
        for (int i = 0; i<rows; i++)
        {
            for (int j = 0; j<cols;j++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] rnd3DArray = NoRepeats3DArray(3, 2, 2, 1, 12);
Show3DArray(rnd3DArray);