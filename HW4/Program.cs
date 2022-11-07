// Домашняя работа № 4 к семинару 7.11.2022
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Pow(int a, int b)
{
    int pow = 1;
    for (int count = 0; count < b; count++)
    {
        pow = pow * a;
    }
    return pow;
}

Console.Write("Введите число, которое нужно возвести в степень: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень, в которую нужно возвести число): ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"При возведении числа {a} в {b} степень получится {Pow(a,b)}");
*/
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumDigit(int num)
{
    int sum = 0;
    while(num != 0)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }
    return sum;
}
Console.Write("Введите число): ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {a} равна {SumDigit(a)}");
*/
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] collection)
{
    int length = 8;
    for (int i = 0; i < length; i++)
    {
        Console.Write("Введите число: ");
        collection[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[]collection2)
{
    int count = 8;
    Console.Write($"Получился массив: [");
    for (int j = 0; j < count; j++)
    {
        Console.Write($"{collection2[j]}, ");
    }
    Console.Write("]");
}

int [] array = new int [10];
Console.WriteLine("Создадим массив из 8 элементов");
FillArray(array);
PrintArray(array);