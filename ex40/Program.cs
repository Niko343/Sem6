// Задача 40: Напишите программу, которая принимает на вход три
//числа и проверяет, может ли существовать треугольник с сторонами
//такой длины.

Console.Write("Введите число 1: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите число 3: ");
int c = int.Parse(Console.ReadLine());
Console.WriteLine();
if( a > b + c)
{
    Console.WriteLine("Треугольник с такими соотношением сторон не существует");
}
else if ( b > a + c)
{
    Console.WriteLine("Треугольник с такими соотношением сторон не существует");
}
else if ( c > a + b)
{
    Console.WriteLine("Треугольник с такими соотношением сторон не существует");
}
else 
{
    Console.WriteLine("Треугольник с сторонами такой длины существует");
}


