int contador = 0;
int vitoriaInter = 0;
int vitoriaGremio = 0;
int empates = 0;
int novoCalculo = 1;

while (novoCalculo == 1)
{
    string[] vet = Console.ReadLine().Split(' ');

    int inter = int.Parse(vet[0]);
    int gremio = int.Parse(vet[1]);

    if (inter == gremio)
    {
        empates++;
    }
    else if (inter > gremio)
    {
        vitoriaInter++;
    }
    else
    {
        vitoriaGremio++;
    }


    Console.WriteLine("Novo grenal (1-sim 2-nao)");
    novoCalculo = int.Parse(Console.ReadLine());
    while (novoCalculo != 1 && novoCalculo != 2)
    {
        Console.WriteLine("Novo grenal (1-sim 2-nao)");
        novoCalculo = int.Parse(Console.ReadLine());
    }

    contador++;
}

Console.WriteLine(contador + " Grenais");
Console.WriteLine("Inter: " + vitoriaInter);
Console.WriteLine("Gremio: " + vitoriaGremio);
Console.WriteLine("Empates: " + empates);
if (vitoriaInter == vitoriaGremio)
{
    Console.WriteLine("Nao houve vencedor");
}
else if(vitoriaInter > vitoriaGremio)
{
    Console.WriteLine("Inter venceu mais");
}
else
{
    Console.WriteLine("Gremio venceu mais");
}

