using System.Globalization;

double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double valor3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double valor4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double valor5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double valor6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


int positivos = 0;

if (valor1 > 0.0)
{
    positivos++;
}

if (valor2 > 0.0)
{
    positivos++;
}

if (valor3 > 0.0)
{
    positivos++;
}

if (valor4 > 0.0)
{
    positivos++;
}

if (valor5 > 0.0)
{
    positivos++;
}

if (valor6 > 0.0)
{
    positivos++;
}

Console.WriteLine(positivos + " valores positivos");
