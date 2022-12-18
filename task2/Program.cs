int num1 = new Random().Next(100, 1000);
Console.WriteLine(num1);

int a = num1 / 100;
int b = (num1 % 100) % 10;

Console.WriteLine($"{a} {b}");