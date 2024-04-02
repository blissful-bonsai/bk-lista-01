// * *Calcular o consumo de combustível por quilômetro.**
// - Exemplo de entrada: Quilometragem inicial = 100 km, Quilometragem final = 200 km, Consumo de combustível = 20 litros
// - Fórmula: Consumo por km = Consumo de combustível / (Quilometragem final - Quilometragem inicial)
// - Exemplo de saída: O consumo de combustível por quilômetro é de 0.1 litros/km.

Console.WriteLine("Insert the initial mileage: ");
double initialKm = double.Parse(Console.ReadLine());

Console.WriteLine("Insert the final mileage: ");
double finalKm = double.Parse(Console.ReadLine());

Console.WriteLine("Insert how much gas was consumed: ");
double consumedGas = double.Parse(Console.ReadLine());

double finalResult = consumedGas / (finalKm - initialKm);
Console.WriteLine(finalResult);
