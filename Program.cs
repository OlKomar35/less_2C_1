//Задача 10: Напишите программу, которая принимает на вход трёхзначное
//число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

int NumberEntry()
{
    Console.Write("Введите трехзначное число= ");
    return Convert.ToInt32(Console.ReadLine());
}

void SecondDigit(int number){
    number = number/10;
    number = number%10;
    Console.WriteLine($"Вторая цифра = {number}");
}

int num = NumberEntry();
SecondDigit(num);
