﻿Console.WriteLine("Введите трёхзначное число");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 99 && n < 1000)
{
    int d = n / 10 % 10;
    Console.WriteLine(d);
}
else
{
    Console.WriteLine("Введено неверное число, попробуйте ещё раз.");
}