// ДЗ выполнил Андрей Майков andmay@mail.ru
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите числа a и b ");
var numberA = Convert.ToInt32(Console.ReadLine()); // чтение строки и перевод в целое число 
int numberB = Convert.ToInt32(Console.ReadLine()); // чтение строки и перевод в целое число 

if (numberA > numberB)
{
    System.Console.WriteLine($"max = {numberA}");
}
else if (numberA < numberB)
{
    System.Console.WriteLine($"max = {numberB}");
}