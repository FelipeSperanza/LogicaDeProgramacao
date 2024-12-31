/* 
Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele comercializa. Para isto,
mandou digitar um conjunto de N mercadorias, cada uma contendo nome, preço de compra e preço
de venda das mesmas. Fazer um programa que leia tais dados e determine e escreva quantas
mercadorias proporcionaram:

lucro< 10%
10% ≤ lucro ≤ 20%
lucro > 20%
Determine e escreva também o valor total de compra e de venda de todas as mercadorias, assim como o
lucro total. 
 */

using System.Globalization;

int N = int.Parse(Console.ReadLine());

string[] produto = new string[N];
double[] precoInicio = new double[N];
double[] precoFinal = new double[N];

for (int i = 0; i < N; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    produto[i] = vet[0];
    precoInicio[i] = double.Parse(vet[1], CultureInfo.InvariantCulture);
    precoFinal[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
}

// 1: vamos encontrar a quantidade para cada faixa de lucro desejada
int contAbaixoDe10 = 0;
int contEntre10E20 = 0;
int contAcimaDe20 = 0;

for (int i = 0; i < N; i++)
{
    double lucro = precoFinal[i] - precoInicio[i];

    double porcentagemDeLucro = lucro / precoInicio[i] * 100.0;

    if (porcentagemDeLucro < 10.0)
    {
        contAbaixoDe10++;
    }
    else if (porcentagemDeLucro <= 20.0)
    {
        contEntre10E20++;
    }
    else
    {
        contAcimaDe20++;
    }
}
Console.WriteLine("Lucro abaixo de 10%: " + contAbaixoDe10);
Console.WriteLine("Lucro entre 10% e 20%: " + contEntre10E20);
Console.WriteLine("Lucro acima de 20%: " + contAcimaDe20);


//valor total de compra
double somaCompra = 0.0;
for (int i = 0; i < N; i++)
{
    somaCompra += precoInicio[i];
}

//valor total de venda
double somaVenda = 0.0;
for (int i = 0; i < N; i++)
{
    somaVenda += precoFinal[i];
}

//lucro total
double lucroTotal = somaVenda - somaCompra;

Console.WriteLine("Valor total de compra: " + somaCompra.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(somaVenda.ToString("Valor total de venda: " + "F2", CultureInfo.InvariantCulture));
Console.WriteLine(lucroTotal.ToString("Lucro total: " + "F2", CultureInfo.InvariantCulture));