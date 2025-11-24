using System.Globalization;

string nome = Console.ReadLine();
double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double salarioTotal = salario + (totalVendas * 0.15);

Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));




