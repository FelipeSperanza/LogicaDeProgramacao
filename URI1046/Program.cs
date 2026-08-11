string[] valores = Console.ReadLine().Split(' ');
int inicio = int.Parse(valores[0]);
int fim = int.Parse(valores[1]);

int duracao = fim - inicio;

if (duracao <= 0)
{
    duracao += 24;
}

Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");