// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void RowSoringMaxMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int maxPos = j;
            for (int f = j + 1; f < array.GetLength(1); f++)
            {
                if(array[i, f]> array[i, maxPos]) maxPos = f;
            }
            int temp = array[i, j];
            array[i, j] = array[i, maxPos];
            array[i, maxPos] = temp;
        }
    }
}

Console.Write("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Console.WriteLine("Исходный массив: ");
Show2dArray(myArray);
Console.WriteLine();
Console.WriteLine("Отсортированный массив: ");
RowSoringMaxMin(myArray);
Show2dArray(myArray);
*/


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int MinSumRow(int[,] array)
{
    int minSum = 0;
    int minSumRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSum += array[0,j];
    }
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0; 
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if(sum < minSum) 
            {
                minSumRow = i;
                minSum = sum;
            }
    }
    return minSumRow;
}

Console.Write("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(m, n, min, max);
Console.WriteLine("Исходный массив: ");
Show2dArray(myArray);
int res = MinSumRow(myArray);
Console.WriteLine($"Наименьшая сумма элементов в {res+1} строке (строка с индексом {res})");