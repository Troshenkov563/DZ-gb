int [] array = new int[10];
Random rnd = new Random();
Console.Write("[");

for (int i = 0; i < array.Length; i++)
 {
    array [i] = rnd.Next(0, 1000);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");

int Method (int a)
{
    return array[a];
}