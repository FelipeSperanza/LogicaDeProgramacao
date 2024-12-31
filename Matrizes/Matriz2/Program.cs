int N = int.Parse(Console.ReadLine());

int[,] A = new int[N, N];

for (int i = 0; i < N; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    for (int j = 0; j < N; j++)
    {
        A[i, j] = int.Parse(vet[j]);
    }
}

//soma linha
int soma = 0;
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        soma += A[i, j];
    }
    Console.WriteLine(soma);
    soma  = 0;
}