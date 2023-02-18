// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
using System;
using static System.Console;
Clear();

Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());

Write("Введите первую позицию элемента в двумерном массиве: ");
int firstPosition = int.Parse(ReadLine());

Write("Введите вторую позицию элемента в двумерном массиве: ");
int secondPosition = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine($"Элемент массива, указанных координат, соответстует значению: {FindElement(array, firstPosition, secondPosition)}");

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

int FindElement(int [,] NewArray, int firstPosition, int secondPosition)
{ 
int resultat =0;
if(firstPosition<= NewArray.GetLength(0) && secondPosition<=NewArray.GetLength(1))
    {
        resultat = NewArray[firstPosition-1,secondPosition-1];
    }
else
    {
        Console.WriteLine("Такой элемент отсутствует в массиве");
    }
    return resultat;
}

