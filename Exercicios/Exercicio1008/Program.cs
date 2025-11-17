using System.Globalization;

int numeroFuncionario = int.Parse(Console.ReadLine());
int horasTrabalhadas = int.Parse(Console.ReadLine());
double valorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

double salario = horasTrabalhadas * valorHora;

Console.WriteLine("NUMBER = " +  numeroFuncionario);
Console.WriteLine("SALARY = U$ " + salario.ToString("F2",CultureInfo.InvariantCulture));