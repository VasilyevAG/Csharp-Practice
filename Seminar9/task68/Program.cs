/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int Akkerman(int m, int n)
{
    if (m == 0)
        return (n + 1);
    else if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else if (m > 0 && n > 0)
        return Akkerman((m - 1), Akkerman(m, n - 1));
    return Akkerman(m, n);
}


Console.Clear();
Console.Write("Введите неотрицательное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
while (m < 0)
{
    Console.Write("Вы ошиблись!\nВведите неотрицательное число M: ");
    m = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введите неотрицательное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 0)
{
    Console.Write("Вы ошиблись!\nВведите неотрицательное число N: ");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Результат: {Akkerman(m, n)}");