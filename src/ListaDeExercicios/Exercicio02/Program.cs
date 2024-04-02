namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Converter a temperatura de graus Fahrenheit para graus Celsius
             * (fahr - 32) * (5/9)
             */

            double converter(int fahr)
            {
                double celsius = (fahr - 32) * (5.0 / 9);
                return celsius;
            }

            Console.WriteLine("Insert the value of the Fahr temperature so we can convert it!");
            int fahr = int.Parse(Console.ReadLine());
            double celsiusResult = converter(fahr);
            Console.WriteLine(celsiusResult);
        }
    }
}
