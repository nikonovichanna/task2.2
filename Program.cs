int number = new Random().Next (1, 100);
System.Console.WriteLine(number);
if (number < 100)
{
   System.Console.WriteLine("третьей цифры нет"); 
}
else
{ 
    while (number > 999)
    {
    number = number / 10;
    }
    number = number % 10;
    System.Console.WriteLine(number);
}
