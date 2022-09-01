Console.WriteLine("Введите число N, соответствующее числу элементов массива: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число a, наименьшее из массива: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b, наибольшее из массива: ");
int b = int.Parse(Console.ReadLine());

int [] InitArray()
{
    int[] arr = new int[N];
    for(int i = 0; i < N; i++)
    {
        arr[i] = new Random().Next(a, b+1);
    }
    return arr;
}

Console.WriteLine(String.Join(", ", InitArray()));