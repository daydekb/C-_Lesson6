// // Массивы и строки

// // Условия задачи №1:
// // Задайте массив символов (тип char []). Создайте строку из
// // символов этого массива.
// // Указание
// // Конструктор строки вида string(char []) не использовать.
// // Пример
// // [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

// string CharsToString(char[] chars)
// {
//     string str = "";
//     for (int i = 0; i < chars.Length; i++)
//     {
//         str += chars[i];
//     }
//     return str;
// }

// char[] chars = new char[]{'a', 'b', 'c', 'd'};
// Console.WriteLine(CharsToString(chars));

// // Условия задачи №2:
// // На основе символов строки (тип string) сформировать массив
// // символов (тип char[]). Вывести массив на экран.
// // Указание
// // Метод строки ToCharArray() не использовать.
// // Пример
// // “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

// using System.Runtime.InteropServices;

// char[] StringToChars (string str)
// {
//     char[] chars = new char[str.Length];
//     for (int i = 0; i < str.Length; i++)
//     {
//         chars[i] = str[i];
//     }
//     return chars;
// }

// void PrintChars(char[] chars)
// {
//     Console.Write("[");
//     for (int i = 0; i < chars.Length; i++)
//     {
//         Console.Write($"[{chars[i]}], ");
//     }
// }

// string str = "Hello!";
// PrintChars(StringToChars(str));

// Условия задачи №3:
// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

int Vowels (string str)
{
    int num = 0;
    char [] arr = { 'a', 'e', 'i', 'o', 'u', 'y'};
    for (int i = 0; i < str.Length; i++)
    {
        foreach (char e in arr)
        {
            if (str [i] == e)
            {
                num++;
            }
        }
    }
    return num;
}

Console.Write("Input str:");
string str = Console.ReadLine();

Console.WriteLine(Vowels(str));