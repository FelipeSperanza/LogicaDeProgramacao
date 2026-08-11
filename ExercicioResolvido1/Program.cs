using System.Globalization;

Console.Write("Largura: "); 
double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Comprimento: "); 
double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Preço do metro quadrado: ");
double precoMetro  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double area = largura * comprimento;
double preco = area * precoMetro;

Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PRECO = " + preco.ToString("F2", CultureInfo.InvariantCulture));
