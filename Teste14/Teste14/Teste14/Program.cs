using System.Globalization;

//Distância Entre Dois Pontos

double p1, p2, x1, x2, y1, y2, distancia;

string[] valores = Console.ReadLine().Split(' ');
x1 = Convert.ToDouble(valores[0], CultureInfo.InvariantCulture);
y1 = Convert.ToDouble(valores[1], CultureInfo.InvariantCulture);

valores = Console.ReadLine().Split(' ');
x2 = Convert.ToDouble(valores[0], CultureInfo.InvariantCulture);
y2 = Convert.ToDouble(valores[1], CultureInfo.InvariantCulture);

distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2));

Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));