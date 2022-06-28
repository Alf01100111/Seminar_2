System.Console.Write("ВВедите день недели (от 1 до 7): ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7)
{
    System.Console.WriteLine("Это выходной");
}
else if (0 < day && day < 6)
{
    System.Console.WriteLine("Это буднии день");
}
else
{
    System.Console.WriteLine("Неверный ввод");
}