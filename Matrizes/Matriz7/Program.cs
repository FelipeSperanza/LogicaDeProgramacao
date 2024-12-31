int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());

int[,] A = new int[M, N];

for( int i = 0; i < M; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    for(int j = 0; j < N; j++)
    {
        A[i,j] = int.Parse(vet[j]);
    }
}

for( int i = 0;i < M; i++)
{
    for( int j = 0;j < N; j++)
    {
        Console.Write(A[i,j] + " ");
    }
    Console.WriteLine();
}
