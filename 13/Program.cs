// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("введите число");
void hasThirdNumber(int x){
    int div =1;
    while (x/div>=10){
        div*=10;
    }
    if (div <100){
        Console.WriteLine("слишком маленькое число");
    } else{
        int digit = (x/(div/100))%10;
        Console.WriteLine("третья цифра {0}", digit);
    }
}
hasThirdNumber(Convert.ToInt32(Console.ReadLine()));