// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите число строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("Суммы элементов строк:");
FindMinSumElementsRow(matrix);



void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
        }
    }
}


void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindMinSumElementsRow(int[,] matrix)
{
    int[] sums = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i,j];
        }
        sums[i] = sum;
        Console.WriteLine($"{sums[i]} ");
    }
    int a = 0;
    int min = sums[a];
    int minIndex = a;
    while (a < sums.Length-1)
        {  
            if (sums[a+1] < min)
            {
                min = sums[a+1];
                minIndex = a+1;
            }
            a++;
        }
    Console.WriteLine($"В {minIndex+1} строке минимальная сумма элементов");
}