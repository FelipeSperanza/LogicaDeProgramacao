int N = int.Parse(Console.ReadLine());
int contador = 1;

while ( contador <= 10)
{
    int valor = N * contador;
    Console.WriteLine(contador + " x " + N + " = " + valor );
    contador++;
}

