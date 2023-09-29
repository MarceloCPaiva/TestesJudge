// See https://aka.ms/new-console-template for more information
using System.Globalization;

//Média

double A, B, C, media;

A = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
B = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
C = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

media = ((A * 2) + (B * 3) + (C * 5)) / 10;

Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));