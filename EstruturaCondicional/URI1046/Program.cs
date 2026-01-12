using System.Globalization;

string[] vet = Console.ReadLine().Split(' ');

int inicio = int.Parse(vet[0], CultureInfo.InvariantCulture);
int fim = int.Parse(vet[1], CultureInfo.InvariantCulture);

if (inicio == 0 && fim == 0)
{
    Console.WriteLine("O JOGO DUROU 24 HORA(S)");
}
else if (inicio > fim)
{
    int horas = (24 - inicio) + fim;
    Console.WriteLine("O JOGO DUROU " + horas + " HORA(S)");
}
else
{
    int horas = fim - inicio;
    Console.WriteLine("O JOGO DUROU " + horas + " HORA(S)");

}