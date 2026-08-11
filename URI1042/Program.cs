string[] vet = Console.ReadLine().Split(' ');

int a = int.Parse(vet[0]);
int b = int.Parse(vet[1]);
int c = int.Parse(vet[2]);


if (a > b && a > c)
{
    if (b > c)
    {
        Console.WriteLine(c);
        Console.WriteLine(b);
        Console.WriteLine(a);
        Console.WriteLine();
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
    else
    {
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(a);
        Console.WriteLine();
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}
else if (b > a && b > c)
{
    if (a > c)
    {
        Console.WriteLine(c);
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine();
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
    else
    {
        Console.WriteLine(a);
        Console.WriteLine(c);
        Console.WriteLine(b);
        Console.WriteLine();
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}
else
{
    if (b > a)
    {
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine();
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
    else
    {
        Console.WriteLine(b);
        Console.WriteLine(a);
        Console.WriteLine(c);
        Console.WriteLine();
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

    }
}