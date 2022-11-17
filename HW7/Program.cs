// Домашняя работа к семинару от 17.11.2022
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double [,] CreateRandom2dDoubleArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
        }
    }
    return array;
}
void Show2dDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i,j], 2) + " ");
        }
        Console.WriteLine();
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

double[,] myArray = CreateRandom2dDoubleArray(m, n, min, max);
Console.WriteLine("Массив вещественных чисел: ");
Show2dDoubleArray(myArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
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

void FindElement(int[,] array, int rows, int columns)
{
    if( rows > array.GetLength(0) || columns > array.GetLength(1)) Console.WriteLine("Элемента с такими параметрами не существует!");
    else Console.WriteLine($"Искомый элемент: {array[rows,columns]}");
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
Console.Write("Введите позицию элемента в строке: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента в столбце: ");
int c = Convert.ToInt32(Console.ReadLine());
FindElement(myArray, r, c);
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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
void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(Math.Round(array[i], 2) + " ");
    }
    Console.WriteLine();
}
double[] AverageColumns(int [,] array)
{
    double [] avgArray = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double avg = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avg += array[i, j];
        }
        avgArray[j] = avg / array.GetLength(0);
    }
    return avgArray;
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

double [] arrayRes = AverageColumns(myArray);
Console.WriteLine("Cреднее арифметическое элементов в каждом столбце: ");
ShowArray(arrayRes);

