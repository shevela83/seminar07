// **Задача 49:** Задайте двумерный массив.
//  Найдите элементы, у которых оба индекса чётные,
//   и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 2 3 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 **81** 2 **9**
// 8 4 2 4
// 1 **4** 3 **16**

using System;
using static System.Console;
Console.Clear();
Write("Ввудите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Ввудите количество столбцов массива: ");
int column = int.Parse(ReadLine());
int [,] muss = GetArray(rows, column, 3, 4);
PrintArray(muss);
WriteLine();
FealArray(muss);
PrintArray(muss);
void FealArray(int[,] inArray)
{
    for (int i = 1; i < inArray.GetLength(0); i += 2)
    {
        for (int j = 1; j < inArray.GetLength(1); j += 2)
        {
            inArray[i,j] = Convert.ToInt32(Math.Pow(inArray [i, j], 2));
        }
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
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
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}

 
