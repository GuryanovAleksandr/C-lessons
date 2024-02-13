﻿// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]
int[] array = { -1, -2, -3, -4, -5, 0, 1, 2, 3, 4 };
Console.WriteLine($"Массив ДО: [ {string.Join("; ", array)} ]");
for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1; // array[i] = array[i] * -1;
                    // a = a + 40 (a += 40), b = b - 150 (b -= 150)
}
Console.WriteLine($"Массив ПОСЛЕ: [ {string.Join("; ", array)} ]");