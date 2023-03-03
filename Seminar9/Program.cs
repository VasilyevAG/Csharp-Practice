int Stepen(int a, int b)
{
    if (b == 0)
        return 1;
    return Stepen(a, b - 1) * a;
}


Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Stepen(a, b));