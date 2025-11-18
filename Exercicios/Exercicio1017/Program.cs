using System.Globalization;

int tempo = int.Parse(Console.ReadLine());
int velocidade =  int.Parse(Console.ReadLine());

//12 km por litro

int quilometragem = tempo * velocidade;

double gasolina = quilometragem / 12.0;

Console.WriteLine(gasolina.ToString("F3", CultureInfo.InvariantCulture));

