using System.Globalization;

double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double metroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double area = largura * comprimento;
double preco = area * metroQuadrado;

Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PREÇO = " + preco.ToString("F2", CultureInfo.InvariantCulture));