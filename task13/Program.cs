// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99 || number < -99)
{
    if (number > 1000 || number < -1000)
    {
    while (number > 100 || number < -100)
    {
        number = Math.Abs(number / 10 / 10 % 10);

        Console.Write(number);
        
    }
    }
    else 
    {
        Console.Write(number= number%10);
    }

}
else 
{
    Console.Write("Число не имеет третьей цифры");
}