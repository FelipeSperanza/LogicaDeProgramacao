int N = int.Parse(Console.ReadLine());

int segundos = N % 60;
int resto = N / 60;
int minutos = resto % 60;
int horas = resto / 60;




Console.WriteLine(horas + ":" + minutos + ":" + segundos);