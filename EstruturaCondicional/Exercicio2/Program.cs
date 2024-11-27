using System.Globalization;

string[] vet = Console.ReadLine().Split(' ');

double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

double delta = Math.Pow(B, 2.0) - 4 * A * C;

if(A == 0 || delta < 0.0)
{
    Console.WriteLine("Impossível Calcular");
}
else
{

    double r1 = (-B + Math.Sqrt(delta)) / (2.0 * A);
    double r2 = (-B - Math.Sqrt(delta)) / (2.0 * A);

    Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
    Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
}
 


