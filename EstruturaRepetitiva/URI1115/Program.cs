string[] vet = Console.ReadLine().Split(' ');
int X = int.Parse(vet[0]);
int Y = int.Parse(vet[1]);

while (X != 0 && Y != 0)
{
    if (X > 0 && Y > 0)
    {
        Console.WriteLine("primeiro");
    }
    else if (X > 0 && Y < 0)
    {
        Console.WriteLine("quarto");
    }
    else if (X < 0 && Y < 0)
    {
        Console.WriteLine("terceiro");
    }
    else
    {
        Console.WriteLine("segundo");
    }

    vet = Console.ReadLine().Split(' ');
    X = int.Parse(vet[0]);
    Y = int.Parse(vet[1]);
}
