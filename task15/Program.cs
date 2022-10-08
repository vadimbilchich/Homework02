//Задача 15: Напишите метод, который принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("task15 ");

Console.Write("Enter the figure denoting the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek (int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("(This day is a day off) -> yes");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("This is not a day of the week");
    }
    else Console.WriteLine("(This day is not a day off) -> no");
}

CheckingTheDayOfTheWeek(dayNumber);

