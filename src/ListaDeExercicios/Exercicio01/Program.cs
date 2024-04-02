namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Calcular o volume de uma caixa retangular.
                - Exemplo de entrada: Altura = 5, Largura = 3, Comprimento = 2
                - Fórmula: Volume = Altura * Largura * Comprimento
                - Exemplo de saída: O volume da caixa é 30 unidades cúbicas.*/

            Console.WriteLine("Insert the height value: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the width value: ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the length value: ");
            int length = int.Parse(Console.ReadLine());

            int volume = height * width * length;
            Console.WriteLine("The volume of the rectangular box is: " + volume);
        }
    }
}
