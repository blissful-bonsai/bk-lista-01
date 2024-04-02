// 4. * *Calcular o salário total de um vendedor.**
//   - Exemplo de entrada: Salário base = R$ 1500, Total de vendas = R$ 5000, Comissão (5 % sobre as vendas)
//   - Fórmula: Salário total = Salário base + (Total de vendas * Comissão)
//   - Exemplo de saída: O salário total do vendedor é R$ 2750.

Console.WriteLine("Insert the base wage: ");
double baseWage = double.Parse(Console.ReadLine());

Console.WriteLine("Insert the total sales value: ");
double totalSales = double.Parse(Console.ReadLine());

double finalValue = baseWage + (totalSales * 0.05);
Console.WriteLine(finalValue);