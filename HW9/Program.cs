// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
/*
void ShowNatural(int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNatural(n - 1);
}
Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNatural(n);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNatural(int m, int n)
{
    if(n >= m) return SumNatural(m + 1, n) + m;
    return 0;
}

Console.WriteLine("Введите первое натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма натуральных элементов в промежутке от {m} до {n} равна: ");
if(m > n)
{
    int temp = m;
    m = n;
    n = temp;
} 
Console.WriteLine(SumNatural(m, n));

