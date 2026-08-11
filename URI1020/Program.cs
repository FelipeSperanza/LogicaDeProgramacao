int N = int.Parse(Console.ReadLine());

int anos = N / 365;
int resto = N %  365;
int meses = resto / 30;
int dias = resto % 30;

Console.WriteLine(anos + " ano(s)");
Console.WriteLine(meses + " mes(es)");
Console.WriteLine(dias + " dia(s)");