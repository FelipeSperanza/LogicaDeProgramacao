int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());
int n4 = int.Parse(Console.ReadLine());
int n5 = int.Parse(Console.ReadLine());
int pares = 0;

if(n1 % 2 == 0)
{
    pares++;
}
if (n2 % 2 == 0)
{
    pares++;
}
if (n3 % 2 == 0)
{
    pares++;
}
if (n4 % 2 == 0)
{
    pares++;
}
if (n5 % 2 == 0)
{
    pares++;
}

Console.WriteLine(pares + " valores pares");