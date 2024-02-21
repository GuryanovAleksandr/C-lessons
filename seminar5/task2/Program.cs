// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1; 1) и
// т.д.
// Пример
// 2 3 4 3
//  4 3 4 1 => 2 + 3 + 5 = 10
//  2 9 5 4

int[,] CreateMatrix(int rowCount, int colomsCount)
{
    int[,] matrix = new int[rowCount, colomsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(11);
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
int SumElements(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) // строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
        {
            if (i == j) // номер строки равен номеру столбца
            {
                sum += matrix[i, j];
            }
        }
    }
    return sum;
}
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int coloms = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateMatrix(rows, coloms);
PrintMatrix(matrix);
Console.WriteLine($"Результат: {SumElements(matrix)}");