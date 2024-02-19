// Напишите программу, 
// которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или 
// при вводе числа, сумма цифр которого чётная.


void Main()
{
    for (; ; )
    {
        string inputString = ReadString("Введите целое число. Для завершение программы введите q или числа, сумма цифр которого чётная:");
        if (inputString == "q" || IsEvenDigitsSum(inputString))
        {
            System.Console.WriteLine("STOP");
            break;
        }

    }
}

string ReadString(string message)
{
    System.Console.Write(message);
    return Console.ReadLine();
}

bool IsEvenDigitsSum(string message)
{
    int number = Convert.ToInt32(message);
    int sum = 0;
    while (number != 0)
    {
        int digit = number % 10;
        sum += digit;
        number /= 10;
    }

    return sum % 2 == 0;
}

Main();