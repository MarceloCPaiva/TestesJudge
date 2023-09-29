// See https://aka.ms/new-console-template for more information
using System.Globalization;

// Média

double A, B, media;

A = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
B = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

media = ((A * 3.5) + (B * 7.5)) / 11;

Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));