// Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите количество чисел: ");
int M = int.Parse(Console.ReadLine());
int count = 0;
int[]mass = new int[M];
Console.WriteLine("Введите числа: ");
for (int i = 0; i < mass.Length; i++)
{
    int a = int.Parse(Console.ReadLine());
    mass[i] = a;
}
for (int i = 0; i < mass.Length; i++)
{
    Console.Write(mass[i] + " ");
}
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел больше 0: {count}");