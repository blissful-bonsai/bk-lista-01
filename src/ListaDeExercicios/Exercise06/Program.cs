//6. * *Calcular a área de um terreno retangular.**
//   - Exemplo de entrada: Comprimento do terreno = 10 metros, Largura do terreno = 5 metros
//   - Fórmula: Área = Comprimento * Largura
//   - Exemplo de saída: A área do terreno é 50 metros quadrados.

Console.WriteLine("Insert the length: ");
double length = double.Parse(Console.ReadLine());

Console.WriteLine("Insert the width: ");
double width = double.Parse(Console.ReadLine());

double area = length * width;
Console.WriteLine(area);