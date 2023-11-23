/*
    Задайте массив из вещественных чисел с ненулевой дробной частью. 
Найдите разницу между максимальным и минимальным элементов массива.
*/


/*
    Вариант с рандомным заполнением массива

void FillArray(double[] array)
{
    Console.Write("fill array: ");
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().NextDouble() * 100.0 - 50.0; // диапазон от -50 до 50
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
void FillArray(double[] array)
{
    Console.WriteLine("Enter elements of array:");
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"[{index}] of [{array.Length}]: ");
        array[index] = Convert.ToDouble(Console.ReadLine());
    }
}


void PrintRange(double[] array)
{
    double min = array[0];
    double max = min;

    if (array.Length < 2)
    {
        Console.WriteLine("Array size is too small!");
    } else {

        for (int index = 0; index < array.Length; index++)
        {
            if (array[index] < min)
            {
                min = array[index];
            } else if (array[index] > max)
            {
            max = array[index];
            }
        }
        Console.WriteLine("Range is: " + (max - min));
    }
}

double[] array = new double[3];

FillArray(array);
PrintRange(array);
