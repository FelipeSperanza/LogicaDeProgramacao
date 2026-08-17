using System.Globalization;

int idade = int.Parse(Console.ReadLine());

int contador = 0;
int soma = 0;
double media = 0;

while (idade > 0)
{
    soma += idade;
    contador++;
    idade = int.Parse(Console.ReadLine());


}

media = (double) soma / contador;
Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));