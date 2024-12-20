/*Faça um programa que leia N números reais e armazene-os em um vetor. 
 * Em seguida, mostrar na tela o maior número 
do vetor (supor não haver empates). Mostrar também a posição do maior elemento. */

using System.Globalization;

int n = int.Parse(Console.ReadLine());

double[] valor = new double[n];

string[] vet = Console.ReadLine().Split(' ');

for (int i = 0; i < n; i++)
{
   
    valor[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
}

double maior = 0;
int posicao = 0;
for (int i = 0; i < n; i++)
{
    if(valor[i] > maior)
    {
        maior = valor[i];
        posicao = i;
    }
}

Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
Console.WriteLine(posicao);

