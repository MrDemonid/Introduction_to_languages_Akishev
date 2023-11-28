/*
    Задайте массив заполненный случайными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
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
    Console.Write("[ ");
    for (int idx = 0; idx < array.Length; idx++)
    {
        Console.Write(array[idx]);
        if (idx < array.Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine(" ]");
}


/*
    подсчитывает количество чётных элементов в массиве
*/
int GetCountOfEvenNumber(int[] array)
{
    int result = 0;

    foreach (int n in array)
    {
        if ((n & 0x01) == 0)
        {
            result++;
        }
    }
    return result++;
}

Console.Clear();
Console.WriteLine("Generate an array...");
int[] array = CreateRandomArray(10, 100, 999);
PrintArray(array);
Console.WriteLine($"Even numbers in the array = {GetCountOfEvenNumber(array)}");
