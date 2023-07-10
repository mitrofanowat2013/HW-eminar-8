// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

const int Rows = 3;
const int Columns = 4;
int[,] GetrandomMatrix(int row, int columns)
{
int[,] matrix = new int[row, columns];
for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1,10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j= 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
}
}
void SwapFirstAndLastRows(int[,] array)

{
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++)
       {
        for (int z = 0; z < array.GetLength(1)-1;z++)
        {
            if (array[i, z] < array[i, z +1])
            {
                int temp = array[i, z + 1];
                array[i,z + 1] = array[i, z];
                array[i,z] = temp;

            }
        }
       }
    }
}
int[,] myMatrix = GetrandomMatrix(Rows, Columns);
PrintMatrix(myMatrix);
SwapFirstAndLastRows(myMatrix);
Console.WriteLine();
PrintMatrix(myMatrix);
