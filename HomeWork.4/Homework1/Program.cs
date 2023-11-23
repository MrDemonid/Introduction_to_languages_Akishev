/*
     Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, 
значения которых лежат в отрезке [20,90].
*/

/*
    Вариант с рандомным заполнением массива

void FillArray(int[] array)
{
    Console.Write("fill array: ");
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(1, 101);
        Console.Write(array[index]);
        if (index < array.Length-1)
            Console.Write(", ");
    }
    Console.WriteLine();
}
*/

/*
    Вариант с ручным заполнением массива
*/
void FillArray(int[] array)
{
    Console.WriteLine("Enter elements of array:");
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"[{index}] of [{array.Length}]: ");
        array[index] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintRange(int[] mas, int min, int max)
{
    int count = 0;

    for (int pos = 0; pos < mas.Length; pos++)
    {
        if ((mas[pos] >= min) && (mas[pos] <= max))
        {
            count++;
        }
    }
    Console.WriteLine($"Num of elements in range [{min}..{max}] = {count}");
}

int[] array = new int[10];

FillArray(array);
PrintRange(array, 20, 90);
