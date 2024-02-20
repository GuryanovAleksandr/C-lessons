// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3    4 3 4 3
// 4 3 4 1 => 4 3 4 1
// 2 9 5 4    2 9 25 4

int[,] CreateMatrix(int rowCount, int colomsCount)
{
    int[,] matrix = new int[rowCount, colomsCount];
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
void ShowMatrix(int[,] matrix)
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
int[,] matrix = CreateMatrix(3, 2);
ShowMatrix(matrix);