// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double PerX(double k1, double k2, double b1, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double PerY(double k2, double b2, double x)
{
    double y = k2 * x + b2;
    return y;
}

Console.WriteLine("Введите b1 ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k1 ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b2 ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k2 ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = PerX(k1, k2, b1, b2);
double y = PerY(k1, b1, x);


Console.WriteLine($"Точка пересечения двух прямых ( {x} ; {y} )");