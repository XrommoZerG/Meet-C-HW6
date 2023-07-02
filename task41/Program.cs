// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] Vod(int lenght)
{

    int[] mass = new int[lenght];

    for (int i = 0; i < lenght; i++)
    {
        Console.WriteLine($"Введите число {i}:");
        mass[i] = Convert.ToInt32(Console.ReadLine());
    }
    return mass;
}

int Stav(int[] mass)
{
    int coll = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > 0)
        {
            coll++;
        }
    }
    return coll;
}
Console.WriteLine("Сколько чисел вы ведёте - ");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array = Vod(lenght);
string chis = " ";

if (Stav(array) > 4 || Stav(array) == 0)
{
    chis = "чисел";
}
else if (Stav(array) == 1)
{
    chis = "число";
}
else
{
    chis = "числа";
}

Console.WriteLine($"Пользователь вёл {Stav(array)} чисел больше 0 ");

