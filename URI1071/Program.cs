int X = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());
int soma = 0, aux;


if (X > Y)
{
    aux = X;
    X = Y;
    Y = aux;

}

for (int i = X+1; i < Y; i++)
{
    if (i % 2 != 0)
    {
        soma += i;
    }
   
}

Console.WriteLine(soma);