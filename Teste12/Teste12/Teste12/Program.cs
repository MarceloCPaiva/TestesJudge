// See https://aka.ms/new-console-template for more information
using System.Globalization;

//Área

double A, B, C, areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;

string [] vet = (Console.ReadLine().Split(' '));

A = Convert.ToDouble(vet[0], CultureInfo.InvariantCulture);
B = Convert.ToDouble(vet[1], CultureInfo.InvariantCulture);
C = Convert.ToDouble(vet[2], CultureInfo.InvariantCulture);

areaTriangulo = (A * C) / 2;
areaCirculo = 3.14159 * (C * C);
areaTrapezio = (A + B) * C / 2;
areaQuadrado = B * B;
areaRetangulo = A * B;

Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));

