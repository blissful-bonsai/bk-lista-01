// 1. * *Verificar se a soma de A + B é menor que C.**
//   - Exemplo de entrada: A = 5, B = 3, C = 10
//   - Exemplo de saída: A + B é menor que C.

Console.WriteLine("A value: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("B Value: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("C value: ");
int c = int.Parse(Console.ReadLine());

int checker = a + b;

if(checker > c)
{
    Console.WriteLine("C is lower");
}
else
{
    Console.WriteLine("C is higher");
} 