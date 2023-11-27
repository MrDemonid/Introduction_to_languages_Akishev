/*
    Дан массив чисел. Необходимо перемножить первый элемент с последним,
второй с предпоследним и тд., и сохранить результат в новый массив.
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

int[] PackArray(int[] array)
{
    int[] result = new int[array.Length / 2 + array.Length % 2];
    
    int size = array.Length / 2;
    for (int i = 0; i < size; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 > 0)
    {
        result[size] = array[size];
    }
    return result;
}

Console.Write("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter array min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter array max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateRandomArray(size, min, max);
PrintArray(arr);
int[] packarr = PackArray(arr);
PrintArray(packarr);
