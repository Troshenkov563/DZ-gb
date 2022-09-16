int[,,] GetArray(int m, int n, int k)
{
    int[,,] result = new int[m, n, k];
    int digit = 10;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int y = 0; y < k; y++)
            {
                result[i, j, y] += digit;
                digit += 5;
            }

        }
    }

    return result;
}


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int y = 0; y < array.GetLength(2); y++)
            {
                Console.Write($"{array[i, j, y]} ({i}, {j}, {y})\t ");
            }

        }
        Console.WriteLine();
    }
}

int[,,] myArray = GetArray(2, 2, 2);
PrintArray(myArray);