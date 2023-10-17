// Напишите программу, которая заполнит спирально
// массив 4 на 4. Например, на выходе получается.

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Реализована матрица произвольных размеров.
int[,] SpiralMatrix(int rows, int cols)
{
    if (rows<=0 || cols<=0)
    {
        return new int[0, 0];
    }
    else
    {
        int count = rows * cols;
        int[,] result = new int[rows, cols];

        int curRow = 0;
        int curCol = 0;

        int minCol = 0;
        int maxCol = cols - 1;
        int minRow = 0;
        int maxRow = rows - 1;

        int dir = 1;

        for (int i = 0; i < count; i++)
        {
            result[curRow, curCol] = i + 1;
            if (dir % 4 == 1)
            {
                if (maxCol - minCol > 0 && curCol < maxCol) curCol++;
                else { curRow++; minRow++; dir++; }
            }
            else if (dir % 4 == 2)
            {
                if (maxRow - minRow > 0 && curRow < maxRow) curRow++;
                else { curCol--; maxCol--; dir++; }
            }
            else if (dir % 4 == 3)
            {
                if (maxCol - minCol > 0 && curCol > minCol) curCol--;
                else { curRow--; maxRow--; dir++; }
            }
            else if (dir % 4 == 0)
            {
                if (maxRow - minRow > 0 && curRow > minRow) curRow--;
                else { curCol++; minCol++; dir++; }
            }
        }
        return result;
    }
}

void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] spiral1 = SpiralMatrix(5,7);
PrintMatrix(spiral1);