// System.Console.WriteLine("Введите число ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// int numberB = Convert.ToInt32(0);
// int numberC = Convert.ToInt32(7);
// int numberD = Convert.ToInt32(23);

// if (numberA % 7 ==0 & numberA % 23 == 0)
// System.Console.WriteLine("Кратно 7 и 23 ");
// else
// {
// System.Console.WriteLine("Не кратно ");
// }

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 ==0 & number % 23 == 0)
    {
        System.Console.WriteLine("кратное 7 и 23");
    }
    else 
    {
        System.Console.WriteLine("не кратное ");
    }

