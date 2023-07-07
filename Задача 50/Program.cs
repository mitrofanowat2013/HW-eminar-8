// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 2
Console.Write("Введите строку: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int columns = Convert.ToInt32(Console.ReadLine());
int n = 5; 
int m = 7; 
Random random = new Random();
int[,] matrix = new int[n, m];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
{
    matrix[i, j] = random.Next(10, 99);
Console.Write("{0} ", matrix[i, j]);
}
Console.WriteLine();
}
    if (rows < 0 | columns > matrix.GetLength(0) | rows < 0 | columns > matrix.GetLength(1))
{
Console.WriteLine("такого числа в массиве нет  ");
}
    else
{
    Console.WriteLine("Значение элемента массива -> {0}", matrix[rows, columns]);
}
Console.ReadLine();
 