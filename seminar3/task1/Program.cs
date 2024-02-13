// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. 
// Программа должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

// тип_данных[] имяМассива =
int[] array = { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
int numberForSearch = 55;
bool isFound = false; // Число не найдено
// for(точка старта; условие; увеличение счетчика)
for (int i = 0; i < array.Length; i++) // array.Length ищет кол-во эл
{
    if (numberForSearch == array[i])
    {
        isFound = true; // Ура, число найдено :)
        break; // Ломает цикл
    }
}
if (isFound) // isFound == true
{
    Console.WriteLine("Да");
}
else // isFound == false
{
    Console.WriteLine("Нет");
}