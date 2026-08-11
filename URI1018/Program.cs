int N = int.Parse(Console.ReadLine());

int cem = N / 100;
int resto = N % 100;
int cinquenta = resto / 50;
resto  = resto % 50;
int vinte = resto / 20;
resto = resto % 20;
int dez = resto / 10;
resto = resto % 10;
int cinco = resto / 5;
resto = resto % 5;
int dois = resto / 2;
int um = resto % 2;

Console.WriteLine(cem + " nota(s) de R$ 100,00"); 
Console.WriteLine(cinquenta + " nota(s) de R$ 50,00"); 
Console.WriteLine(vinte + " nota(s) de R$ 20,00"); 
Console.WriteLine(dez + " nota(s) de R$ 10,00"); 
Console.WriteLine(cinco + " nota(s) de R$ 5,00"); 
Console.WriteLine(dois + " nota(s) de R$ 2,00"); 
Console.WriteLine(um + " nota(s) de R$ 1,00"); 
