/*
    Задайте значения M и N. Напишите программу, которая выведет все 
натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.
Например:
M=1; N=5; -> 1,2,3,4,5
M=4; N=8; -> 4,5,6,7,8
*/


/*
    Ввод корректного натурального числа с консоли.
*/
int EnterNaturalNum(string message)
{
    int res;
    
    while (true)
    {
        Console.Write("Enter {0} number: ", message);
        if (int.TryParse(Console.ReadLine(), out res))
            if (res > 0)
                break;
        Console.WriteLine("The number must be greater than zero!");
    }
    return res;
}


/*
    Собственно задание - вывод натуральных чисел из заданного диапазона
*/
void ShowNumbersFromRange(int start, int end)
{
    if (end < start)
        return;
    ShowNumbersFromRange(start, end-1);     // сначала достигаем начала диапазона
    if (start != end)
        Console.Write(", ");
    Console.Write(end);                     // пошла размотка стека, выводим число
}


Console.Clear();
int startRange = EnterNaturalNum("start");
int endRange = EnterNaturalNum("end");
if (startRange > endRange) 
    (startRange, endRange) = (endRange, startRange);

ShowNumbersFromRange(startRange, endRange);
