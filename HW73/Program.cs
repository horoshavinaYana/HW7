// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int GetIncomingData(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Create2DArray(int col, int row)
{
    return new int[row, col];
}

void Fill2DArray(int[,] array2D, int low, int high)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(low, high);
        }
    }
}

void Print2DArray(int[,] array2D)
{
    int LastCol = array2D.GetLength(1);
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < LastCol; j++)
        {
            if (j == LastCol - 1)
            {
                Console.Write(array2D[i, j]);
            }
            else
            {
                Console.Write($"{array2D[i, j]};");
            }
        }
        Console.WriteLine();
    }
}

void PrintAverageCol(int[,] array2D)
{
    int summ;
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        summ = 0;
        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            summ = summ + array2D[i, j];
        }
        Console.Write($"{(float)summ / array2D.GetLength(0)} ");
    }
}

int col = GetIncomingData("Введите количество столбцов");
int row = GetIncomingData("Введите количество строк");
int[,] arr2D = Create2DArray(col, row);
int low = GetIncomingData("Введите нижнюю границу значений элементов массива");
int high = GetIncomingData("Введите верхнюю границу значений элементов массива");
Fill2DArray(arr2D, low, high);
Print2DArray(arr2D);
PrintAverageCol(arr2D);