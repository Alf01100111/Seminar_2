int number = new Random().Next(1,10000);
int result = 0;
System.Console.WriteLine($"Число {number}");

if (number/100 == 0)
{
    System.Console.WriteLine($"В числе {number} нет третьей цифры!");
}
else
{
    while (number/100 >= 1)                    //если число не трёхзначное заканчиваем цикл 
    {
    result = number % 10;                      //хвост кладём в переменную результат
    number = number / 10;                      //каждый цикл отрезаем хвост пока число не станет трёхзначным
    }
    System.Console.Write($"третья цифра {result}");
}