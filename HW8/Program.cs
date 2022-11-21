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
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
    Console.WriteLine();
}

int [,] MatrixMultiply(int[,] array1, int[,] array2)
{
    int[,] multiMartrix = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < multiMartrix.GetLength(0); i++)
    {
        for (int j = 0; j < multiMartrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                sum += (array1[i,k] * array2[k,j]);
            }
            multiMartrix[i,j] = sum;
        }
    }
    return multiMartrix;
}

Console.Write("Введите колличество строк первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов первой матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество строк второй матрицы: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов второй матрицы: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = CreateRandom2dArray(m, n, min, max);
int[,] matrix2 = CreateRandom2dArray(m2, n2, min, max);
Console.WriteLine("Первая матрица: ");
Show2dArray(matrix1);
Console.WriteLine("Вторая матрица: ");
Show2dArray(matrix2);
if(n == m2)
{
    int[,] resMatrix = MatrixMultiply(matrix1, matrix2);
    Console.WriteLine("Произведение матриц этих матриц: ");
    Show2dArray(resMatrix);
}
else Console.WriteLine("Эти матрицы нельзя перемножить!");
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int [,] CreateSpiralArray(int rows, int minValue)
{
    int[,] spiralArray = new int[rows, rows];

    int i = 0;
    int j = 0;
    int temp = minValue;

    while (minValue <= spiralArray.GetLength(0) * spiralArray.GetLength(1) + temp - 1)
    {
        spiralArray[i, j] = minValue;
        minValue++;
        
        if (i <= j + 1 && i + j < spiralArray.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= spiralArray.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > spiralArray.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return spiralArray;
}
void ShowSpiralArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < 10) Console.Write($"00{array[i,j]} ");
            else if(array[i, j]< 100) Console.Write($"0{array[i, j]} ");
            else Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите начальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateSpiralArray(m, min);
Console.WriteLine("Спиральный массив: ");
ShowSpiralArray(myArray);