// See https://aka.ms/new-console-template for more information
using System.Globalization;

//O Maior

int A, B, C, maiorNumero;

string []vet = (Console.ReadLine().Split(' '));

A = Convert.ToInt32(vet[0], CultureInfo.InvariantCulture);
B = Convert.ToInt32(vet[1], CultureInfo.InvariantCulture);
C = Convert.ToInt32(vet[2], CultureInfo.InvariantCulture);

maiorNumero = Math.Max(Math.Max(A, B), C);

Console.WriteLine(maiorNumero + " eh o maior", CultureInfo.InvariantCulture);