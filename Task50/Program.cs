// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы числа в
// двумерном массиве или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


void PrintArray(int[,] matr)
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
void FillArray(int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            matr[m, n] = new Random().Next(-10, 11);
        }
    }
}
bool IsNumberInArray(int number, int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            if (matr[m, n] == number)
            {
                return true;
            }

        }
    }
    return false;
}

int[,] matrix = new int[3, 4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

Console.WriteLine("\n Введите число: ");
int number = int.Parse(Console.ReadLine());
IsNumberInArray(number, matrix);

Console.WriteLine();
bool IsInArray = false;
for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            if (matrix[m, n] == number)
            {
                IsInArray = true;
                Console.WriteLine($"{m}, {n}");
            }

        }
    }
if (IsInArray)
{
    Console.WriteLine("Введенное число присутствует в массиве");
}
else
{
    Console.WriteLine("Введенное число отсутствует в массиве");
}