// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int Read(string coordinate)
{
    System.Console.Write($"Введите {coordinate}: ");
    int x = int.Parse(Console.ReadLine());
    return x;
}

int xA = Read("x");
int yA = Read("y");
int zA = Read("z");
int xB = Read("x");
int yB = Read("y");
int zB = Read("z");

double LineSegment (double xA, double yA, double zA, double xB, double yB, double zB)
{
      double result = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
      return result;
}

System.Console.WriteLine($"Длина отрезка равна = {LineSegment(xA, yA, zA, xB, yB, zB)}");
