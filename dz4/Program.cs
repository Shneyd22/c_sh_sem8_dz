// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
//построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите 1 число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = new int[x, y, z];
if (x*y*z<=90)
{
FillArray(matrix);
PrintArray(matrix);
}
else
Console.WriteLine("Введенные значения слишком велики");


void FillArray(int[,,] matrix)
{
    int n = 10;
    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
           matrix[x,y,z] = n++;
        }
    }
}


void PrintArray(int[,,] matrix)
{
    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
                {
                    Console.Write($"{matrix[x,y,z]}({x},{y},{z}) ");
                }
            Console.WriteLine();
        }
    }
}