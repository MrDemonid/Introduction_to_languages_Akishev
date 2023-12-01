/*
    Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент 
массива. Под удалением понимается создание нового 
двумерного массива без строки и столбца
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



int[,] CuteArray(int[,] array)
{
    int lastRow = array.GetLength(0)-1;
    int lastCol = array.GetLength(1)-1;
    int rowIndex = 0;                   // индексы минимального элемента
    int colIndex = 0;
    int[,] res = new int[lastRow, lastCol];

    // ищем наименьший элемент
    for (int i = 0; i <= lastRow; i++)
        for (int j = 0; j <= lastCol; j++)
            if (array[i, j] < array[rowIndex, colIndex])
            {
                rowIndex = i;
                colIndex = j;
            }           
    // копируем в новый массив
    int row = 0;
    for (int i = 0; i <= lastRow; i++)
    {
        int col = 0;
        if (i != rowIndex)
        {
            for (int j = 0; j <= lastCol; j++)
            {
                if (j != colIndex)
                {
                    res[row, col] = array[i, j];
                    col++;
                }
            }
            row++;
        }
    }
    return res;
}


/*
    вводим данные для создания массива
*/
Console.Clear();
Console.Write($"Enter rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write($"Enter columns: ");
int cols = Convert.ToInt32(Console.ReadLine());
if (rows > 1 && cols > 1)
{
    Console.Write($"Enter min: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Enter max: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[,] array = CreateRandomMatrix(rows, cols, min, max);
    ShowIntMatrix(array);
    /*
        вырезаем строку и столбец с минимальным элементом
    */
    Console.WriteLine("Result array:");
    int[,] res = CuteArray(array);
    ShowIntMatrix(res);
} else {
    Console.WriteLine("The array can't be less [2,2]!");
}
