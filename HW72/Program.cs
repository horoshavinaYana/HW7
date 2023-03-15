// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

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
bool CheckExist(float[,] array2D, int selrow, int selcol)
{
    int LastCol = array2D.GetLength(1);
    int LastRow = array2D.GetLength(0);
    if (selrow <= LastRow && selcol <= LastCol)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int col = GetIncomingData("Введите количество столбцов");
int row = GetIncomingData("Введите количество строк");
float[,] arr2D = Create2DArray(col, row);
int low = GetIncomingData("Введите нижнюю границу значений элементов массива");
int high = GetIncomingData("Введите верхнюю границу значений элементов массива");
Fill2DArray(arr2D, low, high);
Print2DArray(arr2D);
int selcol = GetIncomingData("Введите номер столбца");
int selrow = GetIncomingData("Введите номер строки");
if (CheckExist(arr2D, selrow, selcol) == true)
{
    Console.WriteLine($"{string.Format("{0:F1}", arr2D[selrow - 1, selcol - 1])}");
}
else
{
    Console.WriteLine($"Строка - {selrow} столбец - {selcol} не существует значения");
}