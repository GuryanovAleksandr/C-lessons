// Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.

int[] CreateArray(int size)
{
    int[] array = new int[size]; // Массив на size элементов
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10); // [0, 9]
    }
    return array;
}

int ConvertArrayToInteger(int[] array)
{
    int result = 0;
    for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
    {
        result = result + array[i] * (int)Math.Pow(10, j);
        // 10 - число, j - степень
    }
    return result;
}

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] res = CreateArray(N); // Создали массив на N элементов
Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
Console.WriteLine($"Результат: {ConvertArrayToInteger(res)}");