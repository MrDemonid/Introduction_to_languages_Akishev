/*
    Напишите программу, которая принимает на вход число и проверяет,
    кратно ли оно одновременно 7 и 23
*/

void IsMmultiples(int num)
{
    if ((num % 7 == 0) && (num % 23 == 0))
    {
        Console.WriteLine($"Число {num} кратно 7 и 23");
    } else {
        Console.WriteLine($"Число {num} не кратное");
    }
}

IsMmultiples(144);
IsMmultiples(322);
IsMmultiples(50);
IsMmultiples(161);