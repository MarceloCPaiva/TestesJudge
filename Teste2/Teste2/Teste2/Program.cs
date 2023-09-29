// See https://aka.ms/new-console-template for more information

//Área do Círculo

using System.Globalization;

double raio, area, pi = 3.14159;

raio = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

area = pi * Math.Pow(raio, 2);

Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));