string number = Console.ReadLine();
while (number.Length != 3)
{
    System.Console.WriteLine("Вы ввели не трехзначное число ");
    number = Console.ReadLine();
}
System.Console.WriteLine(number[1]);

