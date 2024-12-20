/*
Faça um programa que leia N números inteiros e armazene-os em um vetor. Em seguida, mostre na tela:
    - todos os números pares 
    - a quantidade de números pares 
  */

int n = int.Parse(Console.ReadLine());

string[] vet = Console.ReadLine().Split(' ');

int[] valores = new int[n];

for (int i = 0; i < n; i++)
{
    valores[i] = int.Parse(vet[i]);
}

int quantidade = 0;
for (int i = 0; i < n; i++)
{
    if(valores[i] % 2 == 0)
    {
        Console.Write(valores[i] + " ");
        quantidade++;
    }
}
Console.WriteLine();
Console.WriteLine(quantidade);