//Random dice = new Random(); //dice  = dado
// Random dice = new();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);


//Sobrecargas de métodos

// int number = 7;
// string text = "seven";

// Console.WriteLine(number);
// Console.WriteLine();
// Console.WriteLine(text);

// Random dice = new();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50,101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// dice.Next();

//DESAFIO 

int firstValue = 500;
int secondValue = 600;
int largerValue;
int smallerValue;

largerValue = Math.Max(firstValue, secondValue);
smallerValue = Math.Min(firstValue, secondValue);

Console.WriteLine(largerValue);
Console.WriteLine(smallerValue);