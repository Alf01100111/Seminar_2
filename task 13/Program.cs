int number = 3215687;
int result = 0;

if (number/100 == 0)
{
    System.Console.WriteLine($"В числе {number} нет третьей цифры!");
}
while (number/1000 != 0)
{
    number = number / 10;
    result = number % 10;
}

System.Console.Write("третья цифра ");
System.Console.WriteLine(result);