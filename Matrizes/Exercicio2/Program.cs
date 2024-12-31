int N = int.Parse(Console.ReadLine());
int[,] matriz = new int[N,N];

for(int i = 0; i < N; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    for(int j = 0; j < N; j++)
    {
        matriz[i,j] = int.Parse(vet[j]);
    }
}

Console.WriteLine();

Console.WriteLine("DIAGONAL PRINCIPAL:");
for(int i = 0; i < N; i++)
{
    Console.Write(matriz[i,i] + " ");
}

Console.WriteLine();

int cont = 0;
for (int i = 0; i < N; i++)
{
    for(int j = 0; j < N; j++)
    {
        if(matriz[i,j] < 0)
        {
            cont++;
        }
    }
}

Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + cont);