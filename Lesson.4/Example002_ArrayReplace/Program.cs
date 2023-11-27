/*
    Задан массив, с числами диапазона [-10..10].
Поменять знаки значений элементов массива на противоположные.
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

void PrintArray(int[] array)
{
    for (int idx = 0; idx < array.Length; idx++)
    {
        Console.Write(array[idx]);
        if (idx < array.Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}

void InvertArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}


Console.Write("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
PrintArray(array);
InvertArray(array);
PrintArray(array);
