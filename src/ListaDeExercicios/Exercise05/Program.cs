﻿// 5. * *Calcular a média ponderada de duas provas realizadas por um aluno.**
//   - Exemplo de entrada: Nota da primeira prova = 7, Peso da primeira prova = 0.4, Nota da segunda prova = 8, Peso da segunda prova = 0.6
//   - Fórmula: Média ponderada = (Nota da primeira prova * Peso da primeira prova) + (Nota da segunda prova * Peso da segunda prova)
//   - Exemplo de saída: A média ponderada do aluno é 7.6.

Console.WriteLine("Insert the first grade: ");
double firstGrade = double.Parse(Console.ReadLine());

Console.WriteLine("Second grade now: ");
double secondGrade = double.Parse(Console.ReadLine());

double finalGrade = (firstGrade * 0.4) + (secondGrade * 0.6);
Console.WriteLine(finalGrade);