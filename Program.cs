// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
using System;
using static System.Console;

Clear();

string[] NewArray(string[] inArray, int size)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= size)
        {
            count++;
        }
    }

    string[] result = new string[count];
    count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= size)
        {
            result[count] = inArray[i];
            count++;
        }
    }
    return result;
}

string[] array = {"Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan"};

WriteLine($"[{String.Join(" | ", NewArray(array, 3))}]");