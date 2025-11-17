using System.Globalization;

double n = 3.14159;

double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double area = n * (raio * raio);

Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));