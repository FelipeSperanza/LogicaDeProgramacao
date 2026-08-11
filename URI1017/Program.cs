using System.Globalization;

int tempoHoras = int.Parse(Console.ReadLine());
int velocidadeMedia = int.Parse(Console.ReadLine());

int distancia = tempoHoras * velocidadeMedia;

double litros = distancia / 12.0;

Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));