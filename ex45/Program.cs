// Задача 45: Напишите программу, которая будет создавать
//копию заданного массива с помощью поэлементного
//копирования. 
void Fill(int size)
{
    int[]array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (int) new Random().Next(0, 10);
    }
    return array;
}
void Print(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
          Console.Write(array[i] + " ");
    }
}
