using System.Globalization;

double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double notaFinal = nota1 + nota2;

Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F2", CultureInfo.InvariantCulture));

if (notaFinal < 60.0)
{
    Console.WriteLine("REPROVADO");
}
