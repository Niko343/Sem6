// Задача 42: Напишите программу, которая будет преобразовывать
//десятичное число в двоичное.
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());
while (A > 0)
{
    Console.Write( A % 2 );
    A = A / 2;
}
