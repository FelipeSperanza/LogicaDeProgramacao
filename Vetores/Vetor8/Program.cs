/*
 
Tem-se um conjunto de dados contendo a altura e o sexo (M, F) de N pessoas.
Fazer um programa que calcule e escreva:

 a maior e a menor altura do grupo
 a média de altura das mulheres
 o número de homens
 
 */


using System.Globalization;

int N = int.Parse(Console.ReadLine());

double[] altura = new double[N];
char[] sexo = new char[N];

for (int i = 0; i < N; i++)
{
    string[] vet = Console.ReadLine().Split(' ');

    altura[i] = double.Parse(vet[0], CultureInfo.InvariantCulture);
    sexo[i] = char.Parse(vet[1]);
}

//menor altura
double menor = 99;
for (int i = 0; i < N; i++)
{
    if (altura[i] < menor)
    {

    menor = altura[i]; 
    }
}

//maior altura
double maior = 0.0;
for (int i = 0; i < N; i++)
{
    if (altura[i] > maior)
    {

        maior = altura[i];
    }
}

//media altura
double media = 0.0;
for (int i = 0; i < N; i++)
{
  media += altura[i];
}

media = media / N;

// homens
int cont = 0;
for (int i = 0; i < N; i++)
{
    if (sexo[i] == 'M' || sexo[i] == 'm')
    {
        cont++;
    }
}

Console.WriteLine("Menor altura = " + menor.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Maior altura = " + maior.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Numero de homens = " + cont);

