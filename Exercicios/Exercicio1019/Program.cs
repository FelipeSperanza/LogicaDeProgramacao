int N = int.Parse(Console.ReadLine());

int horas = N / 3600;
int restante = N % 3600;
int minutos = restante / 60;
int segundos = restante % 60;
Console.WriteLine(horas + ":" + minutos + ":" + segundos);
