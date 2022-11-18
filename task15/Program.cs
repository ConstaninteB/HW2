// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру обозначающую день недель: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number == 1)
{
    Console.Write("Понедельник - нет");
}

if(number == 2)
{
    Console.Write("Вторник - нет");
}

if(number == 3)
 {
 Console.Write("Среда - нет");
 }

if(number == 4)
{
    Console.Write("Четверг - нет");
}
if(number == 5)
{
    Console.Write("Пятница - нет");
}
if(number == 6)
{
    Console.Write("Суббота - да");
}
if(number == 7)
{
    Console.Write("Воскресенье - да");
}
if(number > 7 || number == 0 || number < 0)
{
    Console.Write("Введите корректное число");
}