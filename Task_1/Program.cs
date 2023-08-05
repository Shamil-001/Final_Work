// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 



string[] strings = { "яблоко", "банан", "кот", "пес", "слон", "лиса", "мяч" };
string[] shortStrings = new string[strings.Length];
int count = 0;

for (int i = 0; i < strings.Length; i++)
{
    if (strings[i].Length <= 3)
    {
        shortStrings[count] = strings[i];
        count++;
    }
}

Array.Resize(ref shortStrings, count);

Console.WriteLine(string.Join(", ", strings));
Console.WriteLine(string.Join(", ", shortStrings));