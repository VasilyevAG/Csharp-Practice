/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такой позиции в массиве нет
1 2 -> На данной позиции находиться элемент 4
*/

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 21); // [1, 20]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

int CheckPosition(int[,] matrix, int m, int n)
{
    if (m > matrix.GetLength(0) || n > matrix.GetLength(1)) 
        Console.WriteLine("Такой позиции в массиве нет");
        else {
            //int i = m - 1;
            //int j = n - 1;
            Console.WriteLine($"На данной позиции находится элемент {matrix[m - 1, n - 1]}");
        }
    
    return matrix[m, n];
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Введите строку элемента массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите столбец элемента массива: ");
int n = int.Parse(Console.ReadLine());
PrintMatrix(matrix);
CheckPosition(matrix, m, n);
