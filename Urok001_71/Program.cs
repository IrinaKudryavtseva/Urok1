﻿Random generateNumber = new Random();
int number = generateNumber.Next(100, 1000);
int numberA = number / 100;
Console.WriteLine(numberA);
int numberB = number % 10;
Console.WriteLine(numberB);
// Console.WriteLine(numberA.ToString() + numberB.ToString());
// Console.WriteLine($"{numberA}" + $"{numberB}");
Console.WriteLine(numberA * 10 + numberB);