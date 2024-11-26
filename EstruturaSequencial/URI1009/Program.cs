using System.Globalization;

string nome;
double salarioFixo, totalVenda, salarioTotal;

nome = Console.ReadLine();
salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
totalVenda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

salarioTotal = totalVenda * 15.0 / 100 + salarioFixo;

Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));