// See https://aka.ms/new-console-template for more information
using System.Globalization;

//Esfera

double raio, pi, volume;

pi = 3.14159;
raio = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

volume = (4 / 3.0) * pi * (raio * raio * raio);


Console.WriteLine("VOLUME: " + volume.ToString("F3", CultureInfo.InvariantCulture));
