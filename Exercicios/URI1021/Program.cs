using System.Globalization;

double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

int cem, cinquenta, vinte, dez, cinco, dois, um, cinquentaCentavos, vinteECincoCentavos, dezCentavos, cincoCentavos, umCentavo;
double resto;

cem = (int)N / 100;
resto = N % 100;
cinquenta = (int)resto / 50;
resto = resto % 50;
vinte = (int)resto / 20;
resto = resto % 20;
dez = (int)resto / 10;
resto = resto % 10;
cinco = (int)resto / 5;
resto = resto % 5;
dois = (int)resto / 2;
resto = resto % 2;
um = (int)resto / 1;
resto = resto % 1.0;
cinquentaCentavos = (int)(resto / 0.5);
resto = resto % 0.5;
vinteECincoCentavos = (int)(resto / 0.25);
resto = resto % 0.25;
dezCentavos = (int)(resto / 0.1);
resto = resto % 0.1;
cincoCentavos = (int)(resto / 0.05);
resto = resto % 0.05;
umCentavo = (int)(resto / 0.01);
resto = 0;

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
