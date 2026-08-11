using System.Globalization;

double pi = 3.14159;

int raio = int.Parse(Console.ReadLine());

double volume = (4.0 / 3.0) * pi * Math.Pow(raio, 3);

Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));