// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехначное число: ");
string paramStr = Console.ReadLine();
int paramInt = int.Parse(paramStr);

if (paramStr.Length != 3)
{
    Console.WriteLine("Вы ввели неверное число");
}
else
    Console.WriteLine("Вторая цифра числа равна " + (paramInt % 100) / 10);
