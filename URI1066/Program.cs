int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());
int n4 = int.Parse(Console.ReadLine());
int n5 = int.Parse(Console.ReadLine());
int pares = 0, impares = 0, positivos = 0, negativos = 0;

if (n1 > 0)
{
    positivos++;
    if (n1 % 2 == 0)
    {
        pares++;
    }
    else
    {
        impares++;
    }
}
else
{
    negativos++;

    if (n1 % 2 == 0)
    {
        pares++;
    }
    else
    {
        impares++;
    }
}



if (n2 > 0)
{
    positivos++;
    if (n2 % 2 == 0)
    {
        pares++;
    }
    else
    {
        impares++;
    }
}
else
{
    negativos++;

    if (n2 % 2 == 0)
    {
        pares++;
    }
    else
    {
        impares++;
    }
}



if (n3 > 0)
{
    positivos++;
    if (n3 % 2 == 0)
    {
        pares++;
    }
    else
    {
        impares++;
    }
}
else
{
    negativos++;

    if (n3 % 2 == 0)
    {
        pares++;
    }
    else
    {
        impares++;
    }
}



if (n4 > 0)
{
    positivos++;
    if (n4 % 2 == 0)
    {
        pares++;
    }
    else
    {
        impares++;
    }
}
else
{
    negativos++;

    if (n4 % 2 == 0)
    {
        pares++;
    }
    else
    {
        impares++;
    }
}


if (n5 > 0)
{
    positivos++;
    if (n5 % 2 == 0)
    {
        pares++;
    }
    else
    {
        impares++;
    }
}
else
{
    negativos++;

    if (n5 % 2 == 0)
    {
        pares++;
    }
    else
    {
        impares++;
    }
}

negativos--;

Console.WriteLine(pares + " valor(es) par(es)");
Console.WriteLine(impares + " valor(es) impar(es)");
Console.WriteLine(positivos + " valor(es) positivo(s)");
Console.WriteLine(negativos + " valor(es) negativo(s)");