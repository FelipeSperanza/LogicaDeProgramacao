string[] vet = Console.ReadLine().Split(' ');

int M = int.Parse(vet[0]);
int N = int.Parse(vet[1]);

int[,] matriz = new int[M, N];


for (int i = 0; i < M; i++)
{
    vet = Console.ReadLine().Split(' ');

    for (int j = 0; j < N; j++)
    {
        matriz[i, j] = int.Parse(vet[j] + " ");

    }
}

int soma = 0;
for(int i = 0;i < M; i++)
{
    for (int j = 0;j < N; j++)
    {
        soma += matriz[i, j];
    }
   
    Console.WriteLine(soma);
    soma = 0;
}