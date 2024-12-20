using System.Globalization;

int N = int.Parse(Console.ReadLine());

string[] nome = new string[N];
int[] idade = new int[N];
double[] altura = new double[N];



for (int i = 0; i < N; i++)
{
    string[] s = Console.ReadLine().Split(' ');
    nome[i] = s[0];
    idade[i] = int.Parse(s[1]);
    altura[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
 
}

double media = 0, porcentagem = 0;
for (int i = 0; i < N; i++)
{
    media += altura[i];

    if (idade[i] < 16)
    {
        porcentagem++;
    }
}

media = media / N;
porcentagem = 100 / N * porcentagem;

Console.WriteLine( "Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F1", CultureInfo.InvariantCulture) + "%");

