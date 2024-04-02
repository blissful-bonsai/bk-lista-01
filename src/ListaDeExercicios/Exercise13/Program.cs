// 2. * *Calcular o fatorial de um número e exibir o resultado.**
//   - Exemplo de entrada: Número = 5
//   - Exemplo de saída: 5! = 120.

Console.WriteLine("Insert the number you want to use: ");
int number = int.Parse(Console.ReadLine());

int result = number;
for(int i = number; i != 1; i--)
{
    Console.WriteLine(result);
    result = result * (i - 1);
}
// 5 4 3 2 1
// 5 * 4 = 20 // result * i
// 20 * 3 = 60 // result * i
// 60 * 2 = 120 // result * i
// 120 * 1, unnecessary








