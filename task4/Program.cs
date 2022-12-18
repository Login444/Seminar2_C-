Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if ((num1 % 7 == 0) && (num1 % 23 == 0))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}