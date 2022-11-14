// Домашнее задание к семинару от 14.11.2022
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Вариант 1. С помощью массива.
/*
int [] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1}-ое число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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

int PositiveNumbers(int[] array)
{
    int pos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            pos++;
        }
    }
    return pos;
}

Console.WriteLine("Сколько чисел вы планируете ввести?: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] myArray = FillArray(m);
ShowArray(myArray);
int positivNum = PositiveNumbers(myArray);
Console.WriteLine($"Вы ввели {positivNum} чисел больше нуля");
*/

// Вариант 2. С помощью цикла (без массива).
/*
int PositiveNumbers(int n)
{
    int count = 0;
    int num = 0;
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i + 1}-ое число: ");
        num = Convert.ToInt32(Console.ReadLine());
        if(num > 0) count++;
    }
    return count;
}

Console.WriteLine("Сколько чисел вы планируете ввести?: ");
int m = Convert.ToInt32(Console.ReadLine());

int positivNum = PositiveNumbers(m);
Console.WriteLine($"Вы ввели {positivNum} чисел больше нуля");
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
void LineIndersection(double b1, double k1, double b2, double k2)
{
    if(k1 == k2 && b1 == b2) 
        Console.WriteLine("Прямые совпадают.");
    else if(k1 == k2) 
        Console.WriteLine("Прямые параллельны между собой и не пересекаются.");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
        Console.WriteLine($"Прямые пересекаются в точке с координатами ({Math.Round(x, 2)}, {Math.Round(y, 2)})");
    }
}

Console.WriteLine("Две прямые заданы уравнениями: y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

LineIndersection(b1, k1, b2, k2);
*/