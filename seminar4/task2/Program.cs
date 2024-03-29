﻿// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3] => 2

int[] CreateArray(int size)
{
    int[] array = new int[size]; // Массив на size элементов
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
        // [1, 101) или [1,100]
    }
    return array;
}

int GetCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        // "&&" - "И": апельсины И яблоки
        if (arr[i] % 7 == 0 && arr[i] % 10 == 1)
        {
            count++; // count = count + 1
                     // Число нашли
        }
    }
    return count;
}

// Вызов метода
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] res = CreateArray(N); // Создали массив на N элементов
Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
Console.WriteLine($"Результат: {GetCount(res)}");