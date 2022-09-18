int Sum(int a, int b)
{
    if(b < a) return 0;
    else return b + Sum(a, b-1);
}

Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine(Sum(M, N));