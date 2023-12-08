/*
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
    Вывод на консоль массива
*/
void ShowArray(int[] array)
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


/*
    Вывод элементов массива в обратном порядке
*/
void ShowInversedArray(int[] array)
{
    if (array.Length == 0)
        return;
    ShowInversedArray(array.Skip(1).ToArray());
    if (array.Length > 1)
        Console.Write(", ");
    Console.Write(array[0]);
}

Console.Write("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write($"Enter min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write($"Enter max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);

ShowInversedArray(array);
