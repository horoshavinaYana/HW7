// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


int GetIncomingData(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

float[,] Create2DArray(int col, int row)
{
    return new float[row, col];
}

void Fill2DArray(float[,] array2D, int low, int high)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = (new Random().NextSingle() * (high - low) + low);
        }
    }
}

void Print2DArray(float[,] array2D)
{
    int LastCol = array2D.GetLength(1);
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < LastCol; j++)
        {
            if (j == LastCol - 1)
            {
                Console.Write(string.Format("{0:F1}", array2D[i, j]));
            }
            else
            {
                Console.Write($"{string.Format("{0:F1}", array2D[i, j])}; ");
            }
        }
        Console.WriteLine();
    }
}

int col = GetIncomingData("Введите количество столбцов");
int row = GetIncomingData("Введите количество строк");
float[,] arr2D = Create2DArray(col, row);
int low = GetIncomingData("Введите нижнюю границу значений элементов массива");
int high = GetIncomingData("Введите верхнюю границу значений элементов массива");
Fill2DArray(arr2D, low, high);
Print2DArray(arr2D);