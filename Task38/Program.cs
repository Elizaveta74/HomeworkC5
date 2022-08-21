/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным
и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/


Console.WriteLine("Введите количество членов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

double[] array = new double[N];

Random rand = new Random();
// Диапазон дробных чисел от 1 до 100. 
// https://stackoverflow.com/questions/1064901/random-number-between-2-double-numbers/1064907#1064907
array[0] = rand.NextDouble() * 99 + 1;
double minValue = array[0];
double maxValue = array[0];

for (int i = 1; i < array.Length; i++)
{
    array[i] = rand.NextDouble() * 99 + 1;
  
    if (minValue > array[i])
    {
        minValue = array[i];
    }
    
    if (maxValue < array[i])
    {
        maxValue = array[i];
    }
}

double diff = maxValue - minValue;

Console.WriteLine(string.Join("\n", array));
Console.WriteLine($"Минимальное значение = {minValue}");
Console.WriteLine($"Максимальное значение = {maxValue}");
Console.WriteLine($"Разница между максимальным и минимальным значениями = {diff}");

