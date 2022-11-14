// Домашнее задание к семинару от 14.11.2022
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

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

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

