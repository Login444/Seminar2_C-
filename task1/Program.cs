int number = new Random().Next(10,100);
Console.WriteLine(number);

if (number/10 > number%10)
{
    Console.WriteLine(number/10);  // Строгое деление на 10 (без остатка) даст нам "десятки"
}
else
{
    Console.WriteLine(number%10); // Находим остаток от деления на 10, т.е. "единицы"
}