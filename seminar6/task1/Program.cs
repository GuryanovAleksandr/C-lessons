// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.

// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

string GetStringFromCharArray(char[] array)
{
    // array = [‘a’, ‘b’, ‘c’, ‘d’]
    string result = string.Empty; // ""
    foreach (char symbol in array)
    // symbol = 'a', symbol = 'b', symbol = 'c', symbol = 'd'
    {
        result += symbol; // result = result + symbol
                          // result = "" + "a"; result = "a"
                          // result = "a" +"b"; result = "ab"
                          // result = "ab" + "c"; result = "abc"
                          // result = "abc" + "d"; result = "abcd"
    }
    return result;
}
// '1' - char в одинарных, "3rr2" - string в двойных
char[] chars = { '1', 'd', '!', '2', 'f' };
Console.WriteLine($"Массив: [{string.Join(";", chars)}]");
string res = GetStringFromCharArray(chars);
Console.WriteLine($"Строка: {res}");