Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

if(a > b && a > c)
{
    Console.WriteLine("Число {a} больше чем {b} и {c}");
}
else if (b > a && b > c)
{
    Console.WriteLine("Число {b} больше чем {a} и {c}");
}
else
{
    Console.WriteLine("Число {c} больше чем {a} и {b}");
}
