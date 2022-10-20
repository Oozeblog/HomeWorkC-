// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Polindrome5(int num)
{
    if( num % 10 == num / 10000 && (num/10) %10 == (num/1000)%10)
    {
        Console.WriteLine("Да. Это число является палиндромом.");
    }
    else
    {
        Console.WriteLine("Нет. Это число не является палиндромом.");
    }
}
Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 99999 || num < 10000)
{
    Console.WriteLine("Это не пятизначное число!");
}
else
{
    Polindrome5(num);
}
*/

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double x = x2 - x1;
    double y = y2 - y1;
    double z = z2 - z1;
    double dist = Math.Sqrt(x*x + y*y + z*z);
    return dist;
}

Console.WriteLine("Введите координаты первой точки по оси х: ");
double x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки по оси y: ");
double y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки по оси z: ");
double z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки по оси х: ");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки по оси y: ");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки по оси z: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double res = Distance(x, y, z, x2, y2, z2);
Console.WriteLine($"Расстояние между точками равно {Math.Round(res, 2)}");
*/

// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int n)
{
    int i = 1;
    Console.Write($"Кубы чисел от 1 до {n}: ");
    while(i <= n)
    {
        Console.Write(Math.Pow(i, 3) + " ");
        i++;
    }
}
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while(n < 1)
{
    Console.WriteLine("Это некорректное число. Введите число больше единицы: ");
    n = Convert.ToInt32(Console.ReadLine());    
}
Cube(n);
