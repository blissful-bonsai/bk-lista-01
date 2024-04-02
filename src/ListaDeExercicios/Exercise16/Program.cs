// Exibir a tabuada de multiplicação do 1 ao 10.
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.Write($"{j} x {i} = {i * j}\t");
    }
    Console.WriteLine();
}
