﻿string[] vet = Console.ReadLine().Split(' ');

int M = int.Parse(vet[0]);
int N = int.Parse(vet[1]);

int[,] A = new int[M,N];

for(int i = 0; i < M; i++)
{
    vet = Console.ReadLine().Split(' ');

    for(int j = 0; j < N; j++)
    {
        A[i,j] = int.Parse(vet[j]);
    }
}



//VALORES NEGATIVOS
Console.WriteLine("VALORES NEGATIVOS: ");
for(int i = 0; i < M; i++)
{
    for(int j = 0;j < N; j++)
    {
        if(A[i,j] < 0)
        {
            Console.WriteLine(A[i,j]);
        }
    }
}


