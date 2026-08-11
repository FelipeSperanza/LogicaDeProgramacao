using System.Globalization;

double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double reajuste;



if (salario <= 400.0)
{
    reajuste = salario * 0.15;
    salario += salario * 0.15;
    Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Em percentual: 15 %");
}
else if (salario >= 800.01 && salario <= 1200.0)
{
    reajuste = salario * 0.10;
    salario += salario * 0.10;
    Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Em percentual: 10 %");
}
else if (salario >= 1200.01 && salario <= 2000.0)
{
    reajuste = salario * 0.07;
    salario += salario * 0.07;
    Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Em percentual: 7 %");
}
else
{
    reajuste = salario * 0.04;
    salario += salario * 0.04;
    Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Em percentual: 4 %");
}