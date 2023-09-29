// See https://aka.ms/new-console-template for more information
using System.Globalization;

//Salário com Bônus


string vendedor;
double salarioFixo, totalVendasMes;
double comissao = 0.15;  // 15%

vendedor = Console.ReadLine();
salarioFixo = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);  // Ler usando a cultura brasileira
totalVendasMes = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);  // Ler usando a cultura brasileira

double calculoComissao = totalVendasMes * comissao;  // Calcula a comissão
double calculoSalario = salarioFixo + calculoComissao;  // Calcula o salário total

Console.WriteLine("TOTAL = R$ " + calculoSalario.ToString("F2", CultureInfo.InvariantCulture));


