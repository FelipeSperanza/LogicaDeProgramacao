using System.Globalization;

double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double MEDIA = ((A * 3.5) + (B * 7.5)) / 11.0;

Console.WriteLine("MEDIA = " + MEDIA.ToString("F5", CultureInfo.InvariantCulture));