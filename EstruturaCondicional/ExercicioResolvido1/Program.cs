using System.Globalization;

double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double soma = n1 + n2;

if (soma < 60.0)
{
    Console.WriteLine("NOTA FINAL = " + soma.ToString("F1", CultureInfo.InvariantCulture));
    Console.WriteLine("REPROVADO");
}
else
{
    Console.WriteLine("NOTA FINAL = " + soma.ToString("F1", CultureInfo.InvariantCulture));
}