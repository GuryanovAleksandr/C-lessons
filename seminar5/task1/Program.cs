﻿// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3    4 3 4 3
// 4 3 4 1 => 4 3 4 1
// 2 9 5 4    2 9 25 4

int[,] CreateMatrix(int rowsCount, int colomsCount)
{
    int[,] matrix = new int[rowsCount, colomsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(101); // от 0 до 100
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t "); // "\t" = 4 пробела
        }
        Console.WriteLine(); //перенос на новую строку
    }
}

void SquareElements(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
        {
            if (i % 2 == 0 && j % 2 == 0) // номер строки И номер столбца - четные
            {
                matrix[i, j] *= matrix[i, j];// matr[i, j] = matr[i, j] * matr[i, j];
            } 
        }
    }
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int coloms = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateMatrix(rows, coloms);
PrintMatrix(matrix);
Console.WriteLine("Результат:");
SquareElements(matrix); // Изменяем матрицу
PrintMatrix(matrix);cd