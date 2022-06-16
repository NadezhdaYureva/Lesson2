// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);

if (numberInt < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (numberInt > 999)
        numberInt = numberInt / 10;
numberInt = numberInt % 10;
Console.WriteLine("Третья цифра числа " + numberInt);
}




