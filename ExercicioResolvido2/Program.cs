using System.Globalization;

double baseRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double alturaRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double area = baseRetangulo * alturaRetangulo;
double perimetro = (baseRetangulo * 2 + alturaRetangulo * 2);
double diagonal = Math.Sqrt(Math.Pow(baseRetangulo, 2) + Math.Pow(alturaRetangulo, 2));

Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
