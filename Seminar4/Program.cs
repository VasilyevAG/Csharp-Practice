Console.Clear();
Console.Write("Введите число: ");
double n = Convert.ToInt32(Console.ReadLine()), result = 1;
for (int i = 1; i <= n; i++)
  result = result * i; // result *= i;
Console.WriteLine($"Результат: {result}");