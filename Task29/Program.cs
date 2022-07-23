/*
Задача 29:
Напишите программу,
которая задаёт массив из 8 элементов
и выводит отсортированный по модулю массив.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int size = 8;
Random random = new Random();
int[] array = new int[size];
Console.WriteLine(array);

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 35);
}  
Console.Write("Входной массив: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");    
}
Console.WriteLine();

for (int i = 0; i < array.Length - 1; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (Math.Abs(array[i]) > Math.Abs(array[j]))
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
Console.Write("Выходной массив: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}