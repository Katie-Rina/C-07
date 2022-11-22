﻿// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void GetAndShow(int m, int n)
{
    double[,] arr = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int k = new Random().Next(1, 3);
            arr[i, j] = Math.Round((new Random().NextDouble() * 10) * Math.Pow(-1, k), 1);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
GetAndShow(m, n);
