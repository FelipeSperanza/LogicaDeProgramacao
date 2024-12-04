using System.Globalization;

double media = 0;
int contador = 0;

int idade = int.Parse(Console.ReadLine());

while (idade > 0)
{
    media += idade;
    contador++;
    idade = int.Parse(Console.ReadLine());
}

if (contador == 0)
{
    Console.WriteLine("Impossível Calcular");
}
else
{
    media = media / contador;

    Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
}

