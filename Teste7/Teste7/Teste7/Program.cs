// See https://aka.ms/new-console-template for more information
using System.Globalization;

//Cálculo Salário

CultureInfo cultura = new CultureInfo("en-US");

int id, horasTrabalhadas;
double calculoSalario;

id = Convert.ToInt32(Console.ReadLine());
horasTrabalhadas = Convert.ToInt32(Console.ReadLine());
double salarioHora = Convert.ToDouble(Console.ReadLine(), cultura);

calculoSalario = (horasTrabalhadas * salarioHora);

Console.WriteLine("NUMBER = " +  id);
Console.WriteLine("SALARY = U$ " + calculoSalario.ToString("F2", cultura));