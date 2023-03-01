Console.Clear();
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine()), a = 0, b = 1, x;
for (int i = 0; i < n; i++)
{
    Console.Write($"{a} ");
    x = a + b;
    a = b;
    b = x;
    
}
