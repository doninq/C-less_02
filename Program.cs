/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
123456789 -> 3
*/

Console.WriteLine("Введите число: ");
string StNumber = Console.ReadLine();
if (StNumber.Length > 2)
{
    Console.WriteLine(StNumber[2]);
}
else
{
    Console.WriteLine("Третьей цифры у этого числа нет");
}
