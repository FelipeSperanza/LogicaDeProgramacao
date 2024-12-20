/*
Fazer um programa para ler um vetor de N números inteiros. 
Em seguida, mostrar na tela a média aritmética somente  dos números pares lidos.  
 */

using System.Globalization;

int n = int.Parse(Console.ReadLine());

string[] vet = Console.ReadLine().Split(' ');
int[] valores = new int[n];

for (int i = 0; i < n; i++)
{
    valores[i] = int.Parse(vet[i]);
}

double media = 0.0; int cont = 0;
for (int i = 0; i < n; i++)
{
    if(valores[i] %2 == 0)
    {
        media += valores[i];
        cont++;
    }
}

media = media / cont;

Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));