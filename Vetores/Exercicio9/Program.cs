/*
 Fazer um programa para ler um conjunto de nomes de pessoas e suas respectivas idades. 
Depois, mostrar na tela o nome  da pessoa mais velha.
 
 */

int n = int.Parse(Console.ReadLine());

string[] nome = new string[n];
int[] idade = new int[n];

for (int i = 0; i < n; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    nome[i] = vet[0];
    idade[i] = int.Parse(vet[1]);
}


int maior = 0;
string maiorNome ="";
for (int i = 0; i < n; i++)
{
    if (idade[i] > maior)
    {
        maior = idade[i];
        maiorNome = nome[i];
    }
}

Console.WriteLine("Pessoa mais velha: " + maiorNome);

