using System.Globalization;

//Idade em Dias

int idade, anos, meses, dias, resto;

idade = Convert.ToInt32(Console.ReadLine());

anos = idade / 365;
resto = idade % 365;
Console.WriteLine(anos + " ano(s)");

meses = resto / 30;
Console.WriteLine(meses + " mes(es)");

dias = resto % 30;
Console.WriteLine(dias + " dia(s)");    




