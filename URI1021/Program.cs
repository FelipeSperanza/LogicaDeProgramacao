using System.Globalization;

double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

int cem = (int )N / 100;
double resto = N % 100.0;
int cinquenta = (int)resto / 50;
resto = resto % 50.0;
int vinte = (int)resto / 20;
resto = resto % 20.0;
int dez = (int)resto / 10;
resto = resto % 10.0;
int cinco = (int) resto / 5;
resto = resto % 5.0;
int dois = (int) resto / 2;
resto = resto % 2.0;
int um = (int)resto / 1;
resto = resto % 1.0;


int cinquentaCentavos = (int)(resto / 0.5);
resto = resto % 0.5;
int vinteECincoCentavos = (int)(resto / 0.25);
resto = resto % 0.25;
int dezCentavos = (int)(resto / 0.1);
resto = resto % 0.1;
int cincoCentavos = (int)(resto / 0.05);
resto = resto % 0.05;
int umCentavo = (int)(resto / 0.01);




Console.WriteLine("NOTAS:");
Console.WriteLine(cem + " nota(s) de R$ 100.00");
Console.WriteLine(cinquenta + " nota(s) de R$ 50.00");
Console.WriteLine(vinte + " nota(s) de R$ 20.00");
Console.WriteLine(dez + " nota(s) de R$ 10.00");
Console.WriteLine(cinco + " nota(s) de R$ 5.00");
Console.WriteLine(dois + " nota(s) de R$ 2.00");
Console.WriteLine("MOEDAS:");
Console.WriteLine(um + " moeda(s) de R$ 1.00");
Console.WriteLine(cinquentaCentavos + " moeda(s) de R$ 0.50");
Console.WriteLine(vinteECincoCentavos + " moeda(s) de R$ 0.25");
Console.WriteLine(dezCentavos + " moeda(s) de R$ 0.10");
Console.WriteLine(cincoCentavos + " moeda(s) de R$ 0.05");
Console.WriteLine(umCentavo + " moeda(s) de R$ 0.01");
