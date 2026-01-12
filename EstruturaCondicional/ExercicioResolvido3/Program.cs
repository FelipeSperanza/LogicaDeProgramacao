string[] vet = Console.ReadLine().Split(' ');

int numero1 = int.Parse(vet[0]);
int numero2 = int.Parse(vet[1]);
int numero3 = int.Parse(vet[2]);

int menor;

if(numero1 < numero2 && numero1 < numero3)
{
    Console.WriteLine("MENOR = " + numero1);
}
else if (numero2 <  numero3)
{
    Console.WriteLine("MENOR = " + numero2);
}
else
{
    Console.WriteLine("MENOR = " + numero3);
}
