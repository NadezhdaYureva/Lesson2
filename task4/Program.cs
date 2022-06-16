// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

int prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}

int numberInt = prompt("Введите цифру, соответствующую дню недели: ");

if (numberInt < 1 || numberInt > 7)
{
    Console.WriteLine("Цифра не соответствует дню недели");
    Environment.Exit(0);
}
if (numberInt == 6 || numberInt == 7) Console.WriteLine("Цифра соответсвует выходному дню");

else Console.WriteLine("Будний день");

