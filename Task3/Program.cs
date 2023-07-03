/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое* элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
* Сумма всех цифр / их количество(это количество ваших строк) */

Console.Write("Введите число строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns);
PrintArray(array);
double[] average = new double[array.GetLength(1)];
for (int j = 0; j < array.GetLength(1); j++)
{
    double sumOfColumns = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sumOfColumns += array[i, j];
    }
    average[j] = Math.Round(sumOfColumns / array.GetLength(0), 1);
}
Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ", average)}");




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