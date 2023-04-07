// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите число строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int m = Convert.ToInt32(Console.ReadLine());
if (n == m)
{
int[,] matrix = new int[n, m];
FillArray(matrix);
PrintArray(matrix);
}
else
Console.WriteLine("Кол-во строк должно быть равно кол-ву столбцов!");




void FillArray(int[,] matrix) //не могу найти ошибку
{
    int n = 0;
    int count = 0;
    while (count < matrix.GetLength(1)-2)
    {
    int i = 0;
    int j = 0; 
    for (j = 0 + count; j < matrix.GetLength(1) - count; j++)
    {
        matrix[i,j] = n++;
    }
    for (i = 1 + count;  i < matrix.GetLength(0) - count; i++)
    {
        matrix[i,j] = n++;
    }
    for (j = matrix.GetLength(1) - count - 2; j >= 0 + count; j--)
    {
        matrix[i,j] = n++;
    }
    
    for (i = matrix.GetLength(0) - count - 2;  i > 0 + count; i--)
    {
        matrix[i,j] = n++;
    }
    count++;
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