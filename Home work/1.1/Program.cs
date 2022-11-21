Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Первое число больше"); Console.WriteLine(a);
}
else
{
    Console.WriteLine("Второе число больше");Console.WriteLine(b);
}

if (a == b)
{
    Console.WriteLine("Они равны");
}
