// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int Read()
{
    Console.WriteLine("Введите число: ");
    int Number = int.Parse(Console.ReadLine());
    Console.WriteLine(IsPalindrome(num1, num2, num3, num4));
    
    if(Number >= 10000 && Number < 100000)
    {
        Console.WriteLine(Number);
    }
    else
    {
        Console.WriteLine("Ошибка, введите пятизначное число");
    }  
    return Number;
}
int Number = Read();

int num1 = Number % 10;
int num2 = Number / 1000 - 10;
int num3 = Number % 100 / 10;
int num4 = Number / 10000;

int IsPalindrome(int num1, int num2, int num3, int num4)
{
    if(num1 == num4 && num2 == num3)
    {
       Console.WriteLine("Да, это палиндром");
    }
    else
    {
        Console.WriteLine("Это не палиндром");
    }
}