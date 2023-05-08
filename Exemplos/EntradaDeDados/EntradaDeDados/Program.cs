using System.Globalization;
/*
string frase = Console.ReadLine();
string x = Console.ReadLine();
string y = Console.ReadLine();
string z = Console.ReadLine();

string[] vet = Console.ReadLine().Split(' '); //Faz a leitura da linha inteira do vetor, e o resultado é separado nas outras variaveis
string p1 = vet[0];
string p2 = vet[1];
string p3 = vet[2];

Console.WriteLine("Você digitou: ");
Console.WriteLine(frase);
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);
Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);
*/

/*
int n1 = int.Parse(Console.ReadLine());
char ch = char.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

string[] vet = Console.ReadLine().Split(' ');

string p1 = vet[0];
char p2 = char.Parse(vet[1]);
int p3 = int.Parse(vet[2]);
double p4 = double.Parse(vet[3], CultureInfo.InvariantCulture);

Console.WriteLine(n1);
Console.WriteLine(ch);
Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);
Console.WriteLine(p4.ToString("F2", CultureInfo.InvariantCulture));
*/

//Exercicio de fixação

Console.WriteLine("Entre com seu nome completo:");
string nome = Console.ReadLine();

Console.WriteLine("Quantos quartos tem na sua casa?");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com um preço de um produto");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
string[] vet = Console.ReadLine().Split(' ');

string ultimoNome = vet[0];
int idadeVet = int.Parse(vet[1]);
double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

Console.WriteLine(nome);
Console.WriteLine(numero);
Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(ultimoNome);
Console.WriteLine(idadeVet);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));





