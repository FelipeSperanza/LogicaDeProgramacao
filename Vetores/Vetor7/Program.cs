/*
 Fazer um programa para ler um conjunto de N nomes de alunos, bem como as notas que eles tiraram
no 1º e 2º semestres. Cada uma dessas informações deve ser armazenada em um vetor. Depois,
imprimir os nomes dos alunos aprovados, considerando aprovados aqueles cuja média das
notas seja maior ou igual a seis.
  */

using System.Globalization;

int N = int.Parse(Console.ReadLine());

string[] nome = new String[N];
double[] nota1 = new double[N];
double[] nota2 = new double[N];



// inserir dados
for (int i = 0; i < N; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    nome[i] = vet[0];
    nota1[i] = double.Parse(vet[1], CultureInfo.InvariantCulture);
    nota2[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
}

double media = 0.0;
for (int i = 0; i < N; i++)
{
    media = (nota1[i] + nota2[i]) / 2.0;
    if (media >= 6.0)
    {
        Console.WriteLine(nome[i]);
    }
}



