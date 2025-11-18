using System.Globalization;

double pi = 3.14159;
double raio = double.Parse(Console.ReadLine());

double volume = (4 / 3.0) * pi * Math.Pow(raio, 3);

Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));