using System.Globalization;

int N = int.Parse(Console.ReadLine());

double[,] mat = new double[N, N];

for (int i = 0;i < N; i++)
{
    string[] dados = Console.ReadLine().Split(' ');

    for(int j = 0; j < N; j++)
    {
        mat[i, j] = double.Parse(dados[j], CultureInfo.InvariantCulture);
    }
}

double somaPositivos = 0;
int indiceLinha;
int indiceColuna;
double diagonal;

for (int i = 0; i < N; i++)
{  
    for (int j = 0; j < N; j++)
    {
        if (mat[i, j] >= 0)
        {
            somaPositivos = somaPositivos + mat[i, j];
        }
    }
}
Console.WriteLine("SOMA DOS POSITIVOS: " + somaPositivos.ToString("F1", CultureInfo.InvariantCulture));

indiceLinha = int.Parse(Console.ReadLine());

Console.Write("LINHA ESCOLHIDA: ");
for (int i = indiceLinha; i <= indiceLinha; i++)
{
    for(int j = 0; j < N; j++)
    {
        Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
    }
}
Console.WriteLine();

indiceColuna = int.Parse(Console.ReadLine());

Console.Write("COLUNA ESCOLHIDA: ");
for (int i = 0; i < N; i++)
{
    for (int j = indiceColuna; j <= indiceColuna; j++)
    {       
        Console.Write(mat[i, indiceColuna].ToString("F1", CultureInfo.InvariantCulture) + " ");
    }
}
Console.WriteLine();

Console.Write("DIAGONAL PRINCIPAL: ");
for (int i = 0; i < N; i++)
{
    Console.Write(mat[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
}
Console.WriteLine();

Console.WriteLine("MATRIZ ALTERADA:");

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (mat[i, j] < 0)
        {
            mat[i, j] = Math.Pow(mat[i, j], 2.0);
        }        
    }
}

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
    }
    Console.WriteLine();
}