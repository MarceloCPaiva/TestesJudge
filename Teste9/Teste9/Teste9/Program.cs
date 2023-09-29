// See https://aka.ms/new-console-template for more information
//Medidas de um retângulo

using System.Globalization;

double baseRetangulo, alturaRetangulo, area, perimetro, diagonal;

baseRetangulo = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
alturaRetangulo = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

area = baseRetangulo * alturaRetangulo;
perimetro = 2 * (baseRetangulo + alturaRetangulo);
diagonal = Math.Sqrt((baseRetangulo * baseRetangulo) + (alturaRetangulo * alturaRetangulo));

Console.WriteLine("AREA = " +  area.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("PERÍMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL = " +  diagonal.ToString("F4", CultureInfo.InvariantCulture));