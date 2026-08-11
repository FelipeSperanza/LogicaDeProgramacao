using System.Globalization;

string[] vet1 = Console.ReadLine().Split(' ');



int codPca1 = int.Parse(vet1[0]);
int numPeca1 = int.Parse(vet1[1]);
double valorUnitario1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);


string[] vet2 = Console.ReadLine().Split(' ');

int codPca2 = int.Parse(vet2[0]);
int numPeca2 = int.Parse(vet2[1]);
double valorUnitario2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);


double valor = numPeca1 * valorUnitario1 + numPeca2 * valorUnitario2;

Console.WriteLine("VALOR A PAGAR: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));