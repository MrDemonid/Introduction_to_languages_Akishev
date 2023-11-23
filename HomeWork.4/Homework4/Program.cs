/*
    Дано натуральное число в диапазоне от 1 до 100 000. 
Создайте массив, состоящий из цифр этого числа. Старший разряд числа 
должен располагаться на 0-м индексе массива, младший – на последнем. 
Размер массива должен быть равен количеству цифр.
*/

int[] MakeArray(int srcNum)
{
    int[] array;
    int digits = 0;
    int num = srcNum;

    // подсчитываем количество цифр в массиве
    while (num > 0)
    {
        num /= 10;
        digits++;
    }
    /* у нас проверка при вводе числа, так что лишнее, хотя в реальном коде лучше оставить.
    if (digits == 0)
    {
        return null;
    }
    */
    // выделяем память под массив и заполняем его
    array = new int[digits];
    for (int idx = 0; idx < array.Length; idx++)
    {
        array[array.Length-idx-1] = srcNum % 10;
        srcNum /= 10;
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


Console.Write("Enter a number between 1 and 100000: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0 && num <= 100000)
{
    int[] array = MakeArray(num);
    PrintArray(array);
} else {
    Console.WriteLine("Number out of range!");
}
