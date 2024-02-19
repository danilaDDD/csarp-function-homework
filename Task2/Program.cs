/*
 Задайте массив заполненный случайными трёхзначными числами. 
 Напишите программу, которая покажет количество чётных чисел в массиве.
*/

void Main()
{   
    int arraySize = 10;
    int minNumber = 100;
    int maxNumber = 999;
    int[] numbers = GetRandomArray(arraySize, minNumber, maxNumber);
    PrintArray(numbers);
    int evenCount = CalcCountEventNumbers(numbers);
    System.Console.WriteLine($"Количество четных чисел в массиве = {evenCount}");

}

void PrintArray(int[] numbers)
{
  System.Console.WriteLine(string.Join(" ", numbers));
}

int[] GetRandomArray(int arraySize, int minNumber, int maxNumber)
{
    int[] array = new int[arraySize];
    Random random = new Random();
    int count = 0;
    for (int i = 0; i < arraySize; i++)
    {
        int number = random.Next(minNumber, maxNumber);
        if(number % 2 == 0)
            count ++;
        array[i] = number;
    }

    return array;
}

int CalcCountEventNumbers(int[] numbers)
{   
    int count = 0;
    foreach(int number in numbers)
        if(number % 2 == 0)
            count ++;

    return count;
}

Main();
