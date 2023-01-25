// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int NumberInput(string text)
{
    int number;
    Console.WriteLine(text);
    while (true)
    {
        string? str = Console.ReadLine();
        if (int.TryParse(str, out number))
        {
            break;
        }
        else
            System.Console.WriteLine("Введено не число. Попробуйте снова: ");
    }

    return number;
}

int SummOfNumbers(int number)
{
    int answer = 0;
    while (number / 10 > 0)
    {
        answer = answer + (number % 10);
        number = number / 10;
        if (number/10 == 0)
        {
            answer += number;
        }
    }
    return answer;
}

int num = NumberInput("Введите число:");
int numS = SummOfNumbers(num);
System.Console.WriteLine(numS);