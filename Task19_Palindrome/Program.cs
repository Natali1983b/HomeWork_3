// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Task(Read());

int Read()
{
    Console.Write("Введите число: ");
    int Number = int.Parse(Console.ReadLine());
    return Number;
}


void Task(int Number)
{
    if(Number >= 10000 && Number < 100000)
    {
        int reverse = 0;
        int num = Number;
        while(Number > 0)
        {
            reverse = reverse * 10 + Number % 10;
            Number = Number / 10;
        } 
        if(reverse == num)
        {
            Console.WriteLine("Да, это палиндром");
        }
        else
        {
            Console.WriteLine("Это не палиндром");
        }
    }
    else
    {
      Console.WriteLine("Ошибка, введите пятизначное число");  
    }
}

