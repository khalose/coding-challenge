// See https://aka.ms/new-console-template for more information
int fahrenheit = 98;
decimal temperature = ((fahrenheit - 32) * 5m / 9);
Console.WriteLine("The temperature is " + temperature + " degrees Celsius");

fahrenheit = 98;
temperature = ((fahrenheit - 32m) * 5m / 9m);
Console.WriteLine("The temperature is " + Math.Round(temperature) + " degrees Celsius");


