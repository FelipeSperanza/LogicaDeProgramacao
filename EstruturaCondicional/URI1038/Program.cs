using System.Globalization;

string[] vet = Console.ReadLine().Split(' ');

int codigo = int.Parse(vet[0]);
int quantidade = int.Parse(vet[1]);

if(codigo == 1)
{
    double valor = quantidade * 4.0;
    Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
}
else if(codigo == 2)
{
    double valor = quantidade * 4.5;
    Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
}
else if (codigo == 3)
{
    double valor = quantidade * 5.0;
    Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
}
else if  (codigo == 4)
{
    double valor = quantidade * 2.0;
    Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
}
else
{
    double valor = quantidade * 1.5;
    Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
}