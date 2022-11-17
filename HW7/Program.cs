// Домашняя работа к семинару от 17.11.2022
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.



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
    double avg = 0;
    
    double [] avgArray = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            avg = avg + array[i,j];
            count ++;
        }
        avgArray[j] = avg / count;
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

