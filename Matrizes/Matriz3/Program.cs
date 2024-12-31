int N = int.Parse(Console.ReadLine());

int[,] A = new int[N, N];

for (int i = 0; i < N; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    for (int j = 0; j < N; j++)
    {
        A[i,j] = int.Parse(vet[j]);
    }
}

Console.WriteLine();

//maior elemento
int maior = 0;
for (int i = 0;i < N; i++)
{
    for(int j = 0;j < N; j++)
    {
        if(A[i,j] > maior)
        {
            maior = A[i,j];
        }
    }
    Console.WriteLine(maior);
    maior = 0;
}