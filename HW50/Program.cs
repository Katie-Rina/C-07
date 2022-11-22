// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetArray(int m, int n)
{
    int[,] NewArr = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {            
            NewArr[i, j] = new Random().Next(0, 10);
        }
    }
    return NewArr;
}

void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {            
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);
int[,] arr = GetArray(m, n);
PrintArr(arr);
Console.Write("Введите номер строки и номер столбца через пробел: ");
string? coord = Console.ReadLine();
string[] xy = coord.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int x = Convert.ToInt32(xy [0]);
int y = Convert.ToInt32(xy [1]);
if (x > arr.GetLength(0) || y > arr.GetLength(1))
{
    Console.WriteLine("В массиве нет такой позиции");
}
else
{
    Console.WriteLine($"На позиции ({x};{y}) в массиве находится число {arr[x-1,y-1]}");
}
