int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA % numberB == 0)
{
    System.Console.WriteLine("Число  кратное ");
}
else
{
    System.Console.WriteLine("Число не кратное >> остаток  " + numberA % numberB );
}


