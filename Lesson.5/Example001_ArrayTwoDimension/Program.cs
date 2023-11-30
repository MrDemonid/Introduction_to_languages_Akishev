/*
    Найти в массиве элементы, у которых индексы четные и заменить
значения этих элементов на их квадраты.
*/

/*
    вывод на экран двухмерного массива чисел (int)
*/
void ShowIntMatrix(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        Console.Write($"row[{rows}]: ");
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"[{matrix[rows, columns]}] ");
        }
        Console.WriteLine();
    }
}

/*
    создание двухмерного массива чисел, с заполнением случайными значениями
*/
int[,] CreateRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = rnd.Next(min, max+1);
        }
    return result;
}

void Index2dSquare(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                array[i, j] *= array[i, j];
            }
        }
}



Console.Clear();
int[,] array = CreateRandomMatrix(4, 8, 0, 9);
ShowIntMatrix(array);
Index2dSquare(array);
ShowIntMatrix(array);

