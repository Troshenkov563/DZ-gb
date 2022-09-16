int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void NumberRowMinSumElements(int[,] array)
{
    int minSumRow = 0;
    int indexMinSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSumRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minSumRow)
        {
            minSumRow = sumRow;
            indexMinSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"Номер строки с наименьшей суммой элементов: {indexMinSumRow + 1} строка");
}

int[,] myArray = GetArray(4, 2, 0, 10);
PrintArray(myArray);
Console.WriteLine();
NumberRowMinSumElements(myArray);