void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); // [1, 10]
}


void ReleaseArray(int[] array, int[] result)
{
  for (int i = 0; i < result.Length; i++)
    result[i] = array[i] * array[array.Length - 1 - i];
}


Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int[] result = new int[n / 2 + n % 2];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array, result);
Console.WriteLine($"Конечный массив: [{string.Join(", ", result)}]");