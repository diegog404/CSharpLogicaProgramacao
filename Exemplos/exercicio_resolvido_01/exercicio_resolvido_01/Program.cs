using System;
using System.Globalization;

double largura, comprimento, metroQ, area, preco;


largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
metroQ = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

area = largura * comprimento;

preco = area * metroQ;

Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PRECO " + preco.ToString("F2", CultureInfo.InvariantCulture));

