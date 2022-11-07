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
// Вариант1: Запрашиваем у пользователя числа по одному, пока их не наберется 8, выводим массив.
/*
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

int [] array = new int [8];
Console.WriteLine("Создадим массив из 8 элементов");
FillArray(array);
PrintArray(array);
*/

// Вариант2: Запрашиваем у пользователя длину массива, создаем массив из рандомных чисел от 1 до 20, выводим на экран
/*
void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(1, 20);
    }
}

void PrintArray(int[]collection2)
{
    int count = collection2.Length;
    Console.Write($"Получился массив: [");
    for (int j = 0; j < count; j++)
    {
        Console.Write($"{collection2[j]}, ");
    }
    Console.Write("]");
}

Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
FillArray(array);
PrintArray(array);
*/

// Вариант3: Запрашиваем у пользователя массив(в виде ряда чисел без пробелов и запятых), переводим его в массив однозначных чисел
/*
Console.Write("Введите массив чисел: ");
string Number = Console.ReadLine();

int[] Array = new int[Number.Length];
int i;

for(i = 0; i < Number.Length; i++)
{
    Array[i] = Convert.ToInt32(Number[i].ToString());
    Console.Write(Array[i] + ", ");
}
*/