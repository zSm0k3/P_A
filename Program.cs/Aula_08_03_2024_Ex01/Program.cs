using System;

float n1;
float n2;
float n3; 
float n4;
float media;

Console.Write("Informe a 1ª nota: ");
n1 = float.Parse(Console.ReadLine());

Console.Write("Informe a 2ª nota: ");
n2 = float.Parse(Console.ReadLine());

Console.Write("Informe a 3ª nota: ");
n3 = float.Parse(Console.ReadLine());

Console.Write("Informe a 4ª nota: ");
n4 = float.Parse(Console.ReadLine());

media = (n1 + n2 + n3 + n4) / 4;

Console.WriteLine($"A nota final é: {media}");
Console.WriteLine("A nota final é: {0}", media);

if (media >= 7)
{
    Console.WriteLine("Aluno Aprovado");
    Console.WriteLine("Parabéns!");
}
else
{
    Console.WriteLine("Aluno Reprovado");
    Console.WriteLine("Que Pena!");
}
