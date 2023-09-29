//Conversão de Tempo

int N, horas, minutos, resto;

N = Convert.ToInt32(Console.ReadLine());

horas = N / 3600;
resto = N % 3600;

minutos = resto / 60;
resto = N % 60;

Console.WriteLine(horas + ":" + minutos + ":" + resto);