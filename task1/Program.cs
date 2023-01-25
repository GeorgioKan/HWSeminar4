// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int MyPow(int num1, int num2)
{
    int answer = num1;
    for (int i = 1; i < num2; i++)
    {
        answer *= num1;
    }
    return answer;
}

int NaturalNumberInput(string text)
{
    int number;
    Console.WriteLine(text);
    while (true)
    {
        string? str = Console.ReadLine();
        if (int.TryParse(str, out number) && number > 0)
        {
            break;
        }
        else
            System.Console.WriteLine("Введено не натуральное число. Попробуйте снова: ");
    }

    return number;
}

int numA = NaturalNumberInput("Введите число А:");
int numB = NaturalNumberInput("Введите число B:");
int numC = MyPow(numA, numB);
Console.WriteLine(numC);