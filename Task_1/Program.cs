// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// ["Hello","2","world",";-)"] -> ["2",";-)"]

string[] NewStringArray(string[] array)
{
    string[] newStringArray = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newStringArray[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref newStringArray, count);
    return newStringArray;
}

string[] GenerateUserArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1}-ю строку: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

Console.Write("Введите колличество строк: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = GenerateUserArray(size);
string[] newStringArray = NewStringArray(array);
Console.Write($"[{String.Join(", ", array)}] -> ");
Console.Write($"[{String.Join(", ", newStringArray)}]");
