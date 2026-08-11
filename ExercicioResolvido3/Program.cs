using System.Globalization;

string[] vet1 = Console.ReadLine().Split(' ');
string[] vet2 = Console.ReadLine().Split(' ');

string nome1 = vet1[0];
string nome2 = vet2[0];
int idade1 = int.Parse(vet1[1]);
int idade2 = int.Parse(vet2[1]);

double media = (idade1 + idade2) / 2.0;


Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + media.ToString("F1", CultureInfo.InvariantCulture) + " anos");