// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся
//  на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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
WriteLine(FealArray (muss));
int FealArray(int[,] inArray)
{int sum = 0; 
    for (int i = 0; i < inArray.GetLength(0); i ++)
    {
        for (int j = 0; j < inArray.GetLength(1); j ++)
        {
            if (i == j)
            {
                sum += inArray[i,j];
            }
        }
    } return sum;
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

 
