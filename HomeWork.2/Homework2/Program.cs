/*
    Напишите программу, которая принимает на вход координаты точки (X, Y),
    причем X != 0 и Y != 0 и выдаёт номер координатной плоскости, в которой
    находится эта точка.
Четверти нумеруются против часовой стрелки:
                |
            2   |   1
                |
      ----------+-----------
                |
            3   |   4
                |
*/

void ShowQuarter(int x, int y)
{
    Console.Write($"({x}, {y}) =>  ");
    if ((x == 0) || (y == 0))
    {
        Console.WriteLine("Error: coordinates can not be 0!");
    } else {
        if (y > 0)
        {
            // это первая или вторая четверть
            if (x > 0)
            {
                Console.WriteLine("1 quarter");
            } else {
                Console.WriteLine("2 quarter");
            }
        } else {
            // это третья или четвертая четверть
            if (x > 0)
            {
                Console.WriteLine("4 quarter");
            } else {
                Console.WriteLine("3 quarter");
            }
        }
    }
}


ShowQuarter(2, 3);
ShowQuarter(-5, 3);
ShowQuarter(-3, -2);
ShowQuarter(4, -2);
