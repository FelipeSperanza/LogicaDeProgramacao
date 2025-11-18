using System.Globalization;

string[] vet = Console.ReadLine().Split(' ');

string nome = vet[0];
int idade = int.Parse(vet[1]);

string[] vet2 = Console.ReadLine().Split(' ');

string nome2 = vet2[0];
int idade2 = int.Parse(vet2[1]);

double media = (idade + idade2) / 2.0;

Console.WriteLine("A idade média de " + nome + " e " + nome2 + " é de "
    + media.ToString("F1", CultureInfo.InvariantCulture) + " anos");