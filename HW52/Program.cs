// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetAndShow(int m, int n)
{
    int[,] NewArr = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            NewArr[i, j] = new Random().Next(-10, 11);
            Console.Write($"{NewArr[i, j], 6}");
        }
        Console.WriteLine();
    }
    return NewArr;
}

void AverColumns(int[,] array)
{
    double[] average = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        average[j] = (double) sum / array.GetLength(0); 
        Math.Round(average[j], 2);       
        Console.Write($"{average[j], 6}");
    }
}

Console.Clear();
int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);
int[,] arr = GetAndShow(m, n);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
AverColumns(arr);

