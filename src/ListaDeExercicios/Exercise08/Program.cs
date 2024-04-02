int[] array = new int[3];

Console.WriteLine("Insert three numbers, type the number and press enter until there's no more input left");

int firstNumber = int.Parse(Console.ReadLine());
array[0] = firstNumber;
int secondNumber = int.Parse(Console.ReadLine());
array[1] = secondNumber;
int thirdNumber = int.Parse(Console.ReadLine());
array[2] = thirdNumber;

// 10 12 14 (This runs 3 times)
for (int i = 0; i < array.Length; i++) 
{
    for (int j = 0; j < array.Length - 1; j++) // This loop runs twice, since the Length is three, it wont attempt to sort the last value, because there will be no other value to compare it to
    {
        int aux;
        if (array[j] < array[j + 1])
        {
            aux = array[j];
            array[j] = array[j + 1];
            array[j + 1] = aux;
        }
    }
}
Console.WriteLine(array[0]);
Console.WriteLine(array[1]);
Console.WriteLine(array[2]);









