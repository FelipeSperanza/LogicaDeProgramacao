/*
Fazer um programa para ler um vetor de N números reais. Em seguida, mostrar na tela
a média aritmética de todos  elementos. Depois mostrar todos os elementos do vetor
que estejam abaixo da média. 
 */

using System.Globalization;

int n = int.Parse(Console.ReadLine());

string[] vet = Console.ReadLine().Split(' ');
double[] valores = new double[n];

for (int i = 0; i < n; i++)
{
    valores[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
}

double media = 0.0;
for (int i = 0; i < n; i++)
{
    media += valores[i];
}

media = media / n;

Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

for (int i = 0; i < n; i++)
{
    if (valores[i] < media)
    {
        Console.WriteLine(valores[i].ToString("F1", CultureInfo.InvariantCulture));
    }
}

