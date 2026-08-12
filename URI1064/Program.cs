using System.Globalization;

double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double valor3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double valor4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double valor5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double valor6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double media = 0;
int positivos = 0;

if (valor1 > 0.0)
{
    positivos++;
    media += valor1;
}

if (valor2 > 0.0)
{
    positivos++;
    media += valor2;
}

if (valor3 > 0.0)
{
    positivos++;
    media += valor3;
}

if (valor4 > 0.0)
{
    positivos++;
    media += valor4;
}

if (valor5 > 0.0)
{
    positivos++;
    media += valor5;
}

if (valor6 > 0.0)
{
    positivos++;
    media += valor6;
}

media = media / positivos;

Console.WriteLine(positivos + " valores positivos");
Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));