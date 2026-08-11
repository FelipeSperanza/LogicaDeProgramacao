using System.Globalization;

int numeroFuncionario = int.Parse(Console.ReadLine());
int horasTrabalhadas = int.Parse(Console.ReadLine());
double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double salarioFuncionario = horasTrabalhadas * valorHora;

Console.WriteLine("NUMBER = " + numeroFuncionario);
Console.WriteLine("SALARY = U$ " + salarioFuncionario.ToString("F2", CultureInfo.InvariantCulture));