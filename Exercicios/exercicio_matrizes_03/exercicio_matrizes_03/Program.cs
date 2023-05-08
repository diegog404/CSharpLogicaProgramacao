int N = int.Parse(Console.ReadLine());

int[,] mat = new int[N, N];

for (int i = 0;i < N; i++)
{
    string[] dados = Console.ReadLine().Split(' ');

    for(int j = 0; j < N; j++)
    {
        mat[i, j] = int.Parse(dados[j]);
    }
}

int maior = 0;

for (int i = 0; i < N; i++)
{ 
    for (int j = 0; j < N; j++)
    {
        if (mat[i, j] > maior)
        {
            maior = mat[i, j];
        }
    }
    Console.WriteLine(maior);
    maior = 0;
}
