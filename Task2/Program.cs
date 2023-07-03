/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
i = 1, j = 2 -> 2
i = 4, j = 2 -> такого элемента не существует */

int[,] array = GetArray(5, 5);
PrintArray(array);
Console.Write("Введите число i (номер строки): ");
int i = int.Parse(Console.ReadLine()!);
Console.Write("Введите число j (номер столбы): ");
int j = int.Parse(Console.ReadLine()!);
if (i <= array.GetLength(0) && j <= array.GetLength(1))
{
    Console.WriteLine($"i={i}, j={j} -> {array[i - 1, j - 1]}");
}
else Console.WriteLine("такого элемента не существует");

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}