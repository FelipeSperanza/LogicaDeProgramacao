int X = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());

int min, max, soma = 0;

if (X < Y)
{
    min = X;
    max = Y;
}
else
{
    min = Y;
    max = X;
}

for (int i = min + 1; i < max; i++)
{
    if (i % 2 != 0)
    {
        soma += i;
    }
}

Console.WriteLine(soma);