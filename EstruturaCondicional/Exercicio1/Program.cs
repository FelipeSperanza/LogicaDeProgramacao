using System.Globalization;

double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double media = nota1 + nota2;

if(media < 60.00)
{
    Console.WriteLine("NOTA FINAL = " + media.ToString("F1", CultureInfo.InvariantCulture));
    Console.WriteLine("REPROVADO");
}
else
{
    Console.WriteLine("NOTA FINAL = " + media.ToString("F1", CultureInfo.InvariantCulture));
}

