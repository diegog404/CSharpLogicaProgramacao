string[] s = Console.ReadLine().Split(' ');

int M = int.Parse(s[0]);
int N = int.Parse(s[1]);

int[,] numeros = new int[M, N];

for(int i = 0; i < M; i++)
{
    string[] dados = Console.ReadLine().Split(' ');

    for(int j = 0; j < N; j++)
    {
        numeros[i, j] = int.Parse(dados[j]);
    }
}

int[] vet = new int[M];
int soma = 0;

for(int i = 0; i < M; i++)
{
    for(int j = 0; j < N; j++)
    {
        soma = soma + numeros[i, j];
    }
    vet[i] = soma;
    Console.WriteLine(vet[i]);
    soma = 0;
}
