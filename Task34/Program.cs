/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.WriteLine("Введите количество членов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];

Random rand = new Random();

int countEvenNumbers = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 1000); 
  
    if (array[i] % 2 == 0)
    {
        countEvenNumbers++; 
    }
    
}

Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Количество четных чисел = {countEvenNumbers}");
