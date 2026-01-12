string[] vet = Console.ReadLine().Split(' ');

int a = int.Parse(vet[0]);
int b = int.Parse(vet[1]);

if(a < b)
{
    if( b % a == 0)
    {
        Console.WriteLine("Sao Multiplos");
    }
    else
    {
        Console.WriteLine("Não são multiplos");
    }
}
else
{

    if (a % b == 0)
    {
        Console.WriteLine("Sao Multiplos");
    }
    else
    {
        Console.WriteLine("Não são multiplos");
    }
}
