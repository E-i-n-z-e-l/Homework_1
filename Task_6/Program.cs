Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int remainder = (number % 2);

if(remainder == 0)
{
    Console.WriteLine(number+" четное");
}
else
{
    Console.WriteLine(number+" не четное");
}
