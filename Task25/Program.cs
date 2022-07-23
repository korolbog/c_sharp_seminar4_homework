/*
Задача 25:
Напишите цикл,
который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.Write("Введите число a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b: ");
double b = Convert.ToDouble(Console.ReadLine());
double aToThePowerOfB = Math.Pow(a, b);
Console.Write(aToThePowerOfB);
Console.ReadKey();