int number = new Random().Next(1,100000);
int result = 0;
System.Console.WriteLine($"Число {number}");

if (number/100 == 0)
{
    System.Console.WriteLine($"В числе {number} нет третьей цифры!");
}
else
{
    while (number/100 >= 1)
    {
    result = number % 10;
    number = number / 10;
    }
    System.Console.Write("третья цифра ");
    System.Console.WriteLine(result);