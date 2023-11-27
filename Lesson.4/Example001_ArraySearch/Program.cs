/*
    Найти в массиве заданное число и вывести "Да/Нет"
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

bool FindInArray(int[] array, int find)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == find)
            return true;
    }
    return false;
}

Console.Write("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter find number: ");
int find = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
PrintArray(array);
if (FindInArray(array, find) == true)
{
    Console.WriteLine("YES");
} else {
    Console.WriteLine("NO");
}
