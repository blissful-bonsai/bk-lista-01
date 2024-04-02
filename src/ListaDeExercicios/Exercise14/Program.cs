// Imprimir a sequência de Fibonacci até um número informado.
//     Exemplo de entrada: Número = 50
//     Exemplo de saída: Sequência de Fibonacci até 50: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34.

Console.WriteLine("Which number do you want the sequence to target?");
int target = int.Parse(Console.ReadLine());

int firstNumber = 0;
int secondNumber = 1;
int thirdNumber = 0;
Console.WriteLine(firstNumber);

while (thirdNumber < target)
{
    thirdNumber = firstNumber + secondNumber; // thirdNumber = 0 + 1
    firstNumber = secondNumber; // First number becomes the second number
    secondNumber = thirdNumber; // Second number becomes the result of the operation, in other words, 0, 1, 1, 2, 0 + 1 = 2. The secondNumber becomes the result, and the first number becomes the second number;
    if (thirdNumber < target)
    {
        Console.WriteLine(thirdNumber);
    }
}

// 0, 1, 1 (first, second, third)
// 1, 1, 2 (first that became the second, second that became the third and third that is the result of the sum) // The order matters, a lot
// 1, 2, 3 (first became the second, second became the third from the previous operation, third is the result of the operation)
// 2, 3, 5 (so on and so forth)

// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34

// firstNumber = 0;
// secondNumber = 1;
// thirdNumber = firstNumber + secondNumber = 1

// firstNumber = 1; was the second number;
// secondNumber = 1 
// thirdNumber = firstNumber + secondNumber;

// firstNumber = 2;
// secondNumber = 3;
// thirdNumber = firstNumber + secondNumber;

// firstNumber = 3;
// secondNumber = 5;
// thirdNumber = 8;






