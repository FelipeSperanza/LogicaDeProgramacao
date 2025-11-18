using System.Globalization;

double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double area = comprimento * altura;
double perimetro = comprimento + comprimento + altura + altura;
double diagonal = Math.Sqrt(Math.Pow(comprimento, 2) + Math.Pow(altura, 2));

Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
