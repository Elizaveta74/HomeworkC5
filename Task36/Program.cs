/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.WriteLine("Введите количество членов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];

Random rand = new Random();

int sum = 0;

for (int i = 1; i < array.Length; i+=2)
{
    array[i] = rand.Next(0, 101); 

    sum += array[i];  
}

Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Сумма чисел с нечетным индексом = {sum}");
