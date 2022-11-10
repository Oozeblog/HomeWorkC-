// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateTrinityArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int HowManyEvenNumbers(int[] array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            even++;
        }
    }
    return even;
}
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateTrinityArray(n);
ShowArray(myArray);
int evenNumber = HowManyEvenNumbers(myArray);
Console.WriteLine($"В данном массиве {evenNumber} чётных чисел");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int SumOddNum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}
Console.WriteLine("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимум диапазона значений массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимум диапазона значений массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
int oddSum = SumOddNum(myArray);
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях массива равна {oddSum}");
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateRandomArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble();
    }
    return array;
}
void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(Math.Round(array[i], 3) + " ");
    }
    Console.WriteLine();
}
double FindDifference(double[] array)
{
    int posMin = 0;
    int posMax = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < array[posMin])
            posMin = i;
        if(array[i] > array[posMax])
            posMax = i;
    }
    Console.WriteLine($"Максимальное значение массива: {Math.Round(array[posMax], 3)}. Минимальное значение массива: {Math.Round(array[posMin], 3)}.");
    double diff = array[posMax] - array[posMin];
    return diff;
}
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(n);
Console.Write("Получившийся массив: ");
ShowArray(myArray);
double difference = FindDifference(myArray);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {Math.Round(difference, 3)}");
*/