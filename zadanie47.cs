double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double x = new Random().NextDouble();
            result[i, j] = new Random().Next(minValue, maxValue + 1) * x;
        }
    }

    return result;
} 

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f2}\t ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите min: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите max: ");
int max = int.Parse(Console.ReadLine());


double[,] myArray = GetArray(m, n, min, max);
PrintArray(myArray);