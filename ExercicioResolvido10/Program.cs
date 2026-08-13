using System.Globalization;

double idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double soma = 0.0;
double contador = 0;

while (idade >= 0.0)
{
    soma += idade;
    contador++;
    idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

if (contador == 0)
{
    Console.WriteLine("impossivel calcular");
}
else
{
    double media = soma / contador;
    Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
}