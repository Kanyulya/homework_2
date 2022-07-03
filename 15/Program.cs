// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int num = Convert.ToInt32(Console.ReadLine());
string[] weekDays = new string[]{"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
if(num == 6 || num == 7)
{
    Console.WriteLine(weekDays[num-1] + " - выходной день");
}
else if (num > 7)
{
    Console.WriteLine("ошибка! в неделе 7 дней!");
}
else
{
    Console.WriteLine(weekDays[num-1] + " - будний день");
};