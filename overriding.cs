// See https://aka.ms/new-console-template for more information
Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(20);
int roll3 = dice.Next(10, 20);
Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

