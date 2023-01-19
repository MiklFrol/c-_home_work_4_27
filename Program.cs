// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();

int getUserNumber(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int sumOfDigits(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum = sum + number % 10; 
        number = number / 10;
    }
    return sum;
}

int number = getUserNumber("Введите число:");
int sum = sumOfDigits(number);
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine($"Сумма цифр в числе {number} = {sum}");