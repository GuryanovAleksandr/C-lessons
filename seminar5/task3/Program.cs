// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

int[,] CreateMatrix(int rows, int columns) //метод создания массива случайных чисел от 0 до 100
{
    int[,] matr = new int[rows, columns]; // [стр, столбцы]
    Random rnd = new Random();
    for (int i = 0; i < rows; i++) // rows = matr.GetLength(0)
    {
        // j, m, k
        for (int j = 0; j < columns; j++) // columns = matr.GetLength(1)
        {
            matr[i, j] = rnd.Next(101); // [0,100], (0, 101)
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // стр
    {
        for (int j = 0; j < matr.GetLength(1); j++) // столбцы
        {
            Console.Write($"{matr[i, j]}\t"); // "\t" = 4 пробела
        } // Закончили обход 0 строки, идем в 1
        Console.WriteLine(); // Перенос на новую строчку
    }
}

double[] GetArrayWithMeans(int[,] matrix)
{
    double[] means = new double[matrix.GetLength(0)];
    // 1 2 means = [1.5, 0]
    // 3 4
    for (int i = 0; i < matrix.GetLength(0); i++) // строки
    {
        double currentSum = 0; // обнуляется после прохода строки
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
        {
            currentSum += matrix[i, j]; // currentSum = currentSum + matrix[i,j] ]
        }
        double currentMean = Math.Round(currentSum / matrix.GetLength(1), 2); //метод Math.Round( , 2) округляет до 2 знаков после запятой
        means[i] = currentMean;
    }
    return means;
}
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrix(rows, cols); // Матрица rows на cols
PrintMatrix(matrix);
double[] res = GetArrayWithMeans(matrix);
Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");