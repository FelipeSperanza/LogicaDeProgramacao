string[] vet1 = Console.ReadLine().Split(' ');
string[] vet2 = Console.ReadLine().Split(' ');

string[] vet3 = Console.ReadLine().Split(' ');
string[] vet4 = Console.ReadLine().Split(' ');

int diaInicio = int.Parse(vet1[1]);
int horaInicio = int.Parse(vet2[0]);
int minutoInicio = int.Parse(vet2[2]);
int segundoInicio = int.Parse(vet2[4]);

int diaFim = int.Parse(vet3[1]);
int horaFim = int.Parse(vet4[0]);
int minutoFim = int.Parse(vet4[2]);
int segundoFim = int.Parse(vet4[4]);



int quantidadeDias =  (diaFim - diaInicio) -1;
int totalHoras = 24 - (horaInicio - horaFim);
int totalMinutos = minutoFim - minutoInicio;
int totalSegundos = segundoFim - segundoInicio;



Console.WriteLine(quantidadeDias + " dia(s)");
Console.WriteLine(totalHoras + " hora(s)");
Console.WriteLine(totalMinutos + " minuto(s)");
Console.WriteLine(totalSegundos + " segundo(s)");







