// ДЗ выполнил Андрей Майков andmay@mail.ru
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите числа a и b ");
int numberA = Convert.ToInt32(Console.ReadLine()); 
int numberB = Convert.ToInt32(Console.ReadLine()); 

Console.Write($"a = {numberA}; b = {numberB} -> max = "); //выводим начало строки

if (numberA > numberB) 
{
    System.Console.WriteLine(numberA); // выводим окончание строки
}
else if (numberA < numberB)
{
    System.Console.WriteLine(numberB); // выводим окончание строки
}
