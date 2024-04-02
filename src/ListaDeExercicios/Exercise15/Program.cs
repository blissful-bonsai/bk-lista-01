// Substituir múltiplos de 3 pela palavra "Fizz" e múltiplos de 5 pela palavra "Buzz" na contagem de 1 a 100.

int number = 1;

while (number < 100)
{
    if (number % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (number % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(number);
    }
    number++;

}