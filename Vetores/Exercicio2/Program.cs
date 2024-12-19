using System.Globalization;

int n = int.Parse(Console.ReadLine());
double soma = 0, media = 0;
double[] vet = new double[n];

string[] s = Console.ReadLine().Split(' ');

for (int i = 0; i < n; i++)
{
    vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
}

for (int i = 0; i < n; i++)
{
    Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
    soma += vet[i];
}

Console.WriteLine();
media = soma / n;
Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));