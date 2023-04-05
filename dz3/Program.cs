// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите число строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int m = Convert.ToInt32(Console.ReadLine());
if (n == m)
{
int[,] matrix1 = new int[n, m];
int[,] matrix2 = new int[n, m];
int[,] matrixResult = new int[n, m];
FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();
FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();
MatrixMutiplication(matrix1, matrix2, matrixResult);
PrintArray(matrixResult);
}
else
Console.WriteLine("Кол-во строк должно быть равно кол-ву столбцов!");




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

void MatrixMutiplication(int[,] matrix1, int[,] matrix2, int[,] matrixResult)
{
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            for (int count = 0; count < matrixResult.GetLength(0); count++)
            {
                matrixResult[i,j] = matrixResult[i,j] + matrix1[i,count] * matrix2[count,j];
            }
        }
    }
}