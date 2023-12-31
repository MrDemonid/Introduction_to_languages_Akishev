﻿/*
    Задайте произвольный массив. Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.
[1,2,5,0,10,34] -> 34 10 0 5 2 1
*/


/*
    Создание массива int[] с заполнением случайными значениями из диапазона [min..max]
*/
int[] CreateRandomArray(int size, int min, int max)
{
    Random rnd = new Random();
    int[]array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
    return array;
}


/*
    Вывод элементов массива в обратном порядке.
    На каждой итерации создается новый массив.
    Медленно, зато без лишних параметров.
*/
void ShowInvertArray(int[] array)
{
    if (array.Length == 0)
        return;
    ShowInvertArray(array.Skip(1).ToArray());
    if (array.Length > 1)
        Console.Write(", ");
    Console.Write(array[0]);
}

/*
    Вывод элементов массива в обратном порядке.
    Вместо создания нового массива используется простой указатель
    "начала" массива, примерно как в реализациях QuickSort.
    Не так эстетично как выше, зато шустро и без перерасхода памяти.
*/
void ShowInvertArrayPosMethod(int[] array, int pos)
{
    if (pos >= array.Length)
        return;
    ShowInvertArrayPosMethod(array, pos+1);
    if (pos < array.Length-1)
        Console.Write(", ");
    Console.Write(array[pos]);
}



Console.Clear();
Console.Write("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write($"Enter min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write($"Enter max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
Console.WriteLine($"{String.Join(", ", array)}");   // show array

// выводим массив в обратном порядке, обоими методами
ShowInvertArrayPosMethod(array, 0);
Console.WriteLine();
ShowInvertArray(array);
