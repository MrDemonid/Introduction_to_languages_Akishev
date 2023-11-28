 /*
    Напишите программу, которая перевернёт одномерный массив (первый 
элемент станет последним, второй – предпоследним и т.д.)
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

void InverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int tmp = array[array.Length-1 - i];
        array[array.Length-1 - i] = array[i];
        array[i] = tmp;
    }
}


Console.Write("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, 10, 99);
PrintArray(array);
InverseArray(array);
PrintArray(array);
