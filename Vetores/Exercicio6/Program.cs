/*
Faça um programa para ler dois vetores A e B, contendo N elementos cada. 
Em seguida, gere um terceiro vetor C onde cada elemento de C é a soma dos 
elementos correspondentes de A e B. Imprima o vetor C gerado.  
 */

int n = int.Parse(Console.ReadLine());

string[] vet1 = Console.ReadLine().Split(' ');
int[] a = new int[n];

string[] vet2 = Console.ReadLine().Split(' ');
int[] b = new int[n];

int[] c = new int[n];

for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(vet1[i]);
}

for (int i = 0; i < n; i++)
{
    b[i] = int.Parse(vet2[i]);
}

for (int i = 0; i < n; i++)
{
    c[i] = a[i] + b[i];
}
for (int i = 0; i < n; i++)
{
    Console.Write(c[i] + " ");
}
