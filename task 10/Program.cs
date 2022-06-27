
System.Console.WriteLine("ВВедите трёхзначное число: ");
int num1 =Convert.ToInt32(Console.ReadLine());
int result = num1 / 10;
result = result % 10;
System.Console.WriteLine($"Второе число - {result}");