/*
Напишите программу, которая перевернёт
одномерный массив (первый элемент станет
последним, второй – предпоследним и т.д.)
*/

void Main()
{   
    string arraySeparator = " ";
    double[] numbersArray = ReadNumbersArray("Введиде массив чисел через пробел:", arraySeparator);
    ReverseArray(numbersArray);
    PrintArray(numbersArray, arraySeparator);

}

double[] ReadNumbersArray(string message, string separator)
{
    System.Console.Write(message);
    string inputMessage = System.Console.ReadLine();
    string[] strNumbers = inputMessage.Split(separator);
    int length = strNumbers.Length;
    double[] numbers = new double[length];
    
    for (int i = 0; i < length; i++)
    {
        numbers[i] = Convert.ToDouble(strNumbers[i]);
    }

    return numbers;
}

void ReverseArray(double[] numbers)
{
    int length = numbers.Length;
    
    for (int i = 0; i < length / 2; i++)
    {
        double buffer = numbers[i];
        numbers[i] = numbers[length - i - 1];
        numbers[length - i - 1] = buffer;
    }
}

void PrintArray(double[] numbers, string separator)
{
  System.Console.WriteLine(string.Join(separator, numbers));
}

Main();