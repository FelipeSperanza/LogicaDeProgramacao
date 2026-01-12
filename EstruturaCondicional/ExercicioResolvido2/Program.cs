
using System.Globalization;


string[] vet = Console.ReadLine().Split(' ');

double a = double.Parse(vet[0]);
double b = double.Parse(vet[1]);
double c = double.Parse(vet[2]);

double delta = b * b - 4 * a * c;


double r1, r2;

if (delta < 0.0 || a == 0)
{
    Console.WriteLine("Impossível calcular");
}
else
{
    r1 = (-b + Math.Sqrt(delta)) / (2 * a);
    r2 = (-b - Math.Sqrt(delta)) / (2 * a);

    Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
    Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));


}



