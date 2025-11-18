using System.Globalization;

string[] vet = Console.ReadLine().Split(' ');

double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

double areaTrianguloRetangulo = A * C / 2.0;
double areaCirculo = 3.14159 * Math.Pow(C, 2);
double areaTrapezio = ((A + B) * C) / 2.0;
double areaQuadrado = Math.Pow(B, 2);
double areaRetangulo = A * B;

Console.WriteLine("TRIANGULO: " + areaTrianguloRetangulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("TRAPÉZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("RETÂNGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));