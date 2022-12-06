// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void PrintArray(double[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            Console.Write($"{matr[m, n]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(double[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            matr[m, n] = new Random().Next(-10, 11);
        }
    }
}
double[,] matrix = new double[3, 4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

Console.WriteLine();

Console.Write("Среднее арифметическое столбцов в массиве: ");
double numbers = 0;
double averageNumbers = 0;
for (int n = 0; n < matrix.GetLength(1); n++)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        numbers = numbers + matrix[m,n] / matrix.GetLength(0);
        averageNumbers = Math.Round(numbers,1);
    }
    Console.Write($"{averageNumbers}; ");
    numbers = 0;
    averageNumbers = 0;
}