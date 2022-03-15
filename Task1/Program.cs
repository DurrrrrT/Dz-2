// string number = Console.ReadLine();
// while (number.Length != 3)
// {
//     System.Console.WriteLine("Вы ввели не трехзначное число ");
//     number = Console.ReadLine();
// }
// System.Console.WriteLine(number[1]);

int number = Convert.ToInt32(Console.ReadLine());
while (number >=1000 || number <= 99)
{
    System.Console.WriteLine("Введите трехзначное число ");
    number = Convert.ToInt32(Console.ReadLine());
}
System.Console.WriteLine(number / 10 % 10);
