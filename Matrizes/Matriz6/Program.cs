using System.Globalization;
using System.Runtime.InteropServices;

int N = int.Parse(Console.ReadLine());
double[,] A = new double[N, N];

for(int i = 0; i < N; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    for(int j = 0; j < N; j++)
    {
        A[i,j] = double.Parse(vet[j], CultureInfo.InvariantCulture);
    }
}

//SOMA POSITIVOS
double soma = 0;
for (int i = 0; i < N; i++)
{
    
    for (int j = 0; j < N; j++)
    {
       if(A[i,j] > 0)
        {
            soma += A[i,j];
        }
    }
}

Console.WriteLine("Escolha uma linha:");
int linha = int.Parse(Console.ReadLine());
Console.WriteLine("Escolha uma coluna:");
int coluna = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));


Console.Write("LINHA ESCOLHIDA: "); 
for (int i = linha; i <=linha; i++)
{
    for (int j = 0; j < N; j++)
    {
                Console.Write(A[linha, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
    }
}

Console.WriteLine();

Console.Write("COLUNA ESCOLHIDA: "); 
for (int i = 0; i < N; i++)
{
        for (int j = coluna; j <= coluna; j++)
    {
        
        Console.Write(A[i, coluna].ToString("F1", CultureInfo.InvariantCulture) + " ");
    }
}

Console.WriteLine();

//DIAGONAL PRINCIPAL
Console.Write("DIAGONAL PRINCIPAL: ");
for (int i = 0; i < N; i++)
{
    Console.Write(A[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
}

//MATRIZ ALTERADA AO QUADRADO
for(int i = 0; i < N; i++)
{
    for(int j = 0 ; j < N; j++)
    {
        if (A[i,j] < 0)
        {
            A[i,j] = Math.Pow(A[i,j], 2);
        }
    }
}
Console.WriteLine();


//MOSTRAR MATRIZ ALTERADA AO QUADRADO
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write(A[i,j].ToString("F1", CultureInfo.InvariantCulture) + " ");
    }
    Console.WriteLine();
}



