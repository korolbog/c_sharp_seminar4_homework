/*
Задача 27:
Напишите программу,
которая принимает на вход число
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int quontient = 1;
int remainder = 0;
int sum = 0;

while (quontient > 0)
{
    remainder = N % 10; 
    quontient = N / 10;
    sum += remainder;
    N = quontient;
}
Console.WriteLine(sum);