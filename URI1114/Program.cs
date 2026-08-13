int senha = int.Parse(Console.ReadLine());

while (senha != 2002)
{
    Console.WriteLine("senha Invalida");
    senha = int.Parse(Console.ReadLine());
}
Console.WriteLine("Acesso Permitido");