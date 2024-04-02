// 3. * *Calcular o Índice de Massa Corporal (IMC) e determinar a condição de peso de um adulto.**
//   - Exemplo de entrada: Peso = 70 kg, Altura = 1.75 m
//   - Fórmula: IMC = Peso / (Altura ^ 2)
//   - Exemplo de saída: IMC = 22.86(Peso normal).

Console.WriteLine("Insert your weight: ");
float weight = float.Parse(Console.ReadLine());

Console.WriteLine("Using a comma, insert your height, in m: ");
float height = float.Parse(Console.ReadLine());

float imc = weight / (height * height);
Console.WriteLine(imc);













