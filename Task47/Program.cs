// Задача 47. Задайте двумерный массив размером m x n, заполненный случайными вещественными числами
// от -10,0 до 10,0.
// m = 3, n = 4.
// 0,5 7,0 -2,0 -0,2
// 1,0 -3,3 8,0 -9,9
// 8,0 7,8 -7,1 9,0


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
            double number = new Random().Next(-10, 11) + new Random().NextDouble();
            matr[m, n] = Math.Round(number, 2);
        }
    }
}
double[,] matrix = new double[3, 4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);