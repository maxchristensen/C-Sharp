int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);

int x = 2100000000;
int y = 2100000000;
// When dealing with extremely high numbers that exceed the 32-bit data type, we need to use a long- which is a 64-bit data type
long z = x + y;
Console.WriteLine(z);

string firstName = "Bob";
int widgetsSold = 7;
// We can add parenthesis to a WriteLine to solve math equations while the complier runs the program.
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

int first = 7;
int second = 5;
// Integers can be used to create a decimal
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

// int value = 1;
// value = value + 1;
// Console.WriteLine("First increment: " + value);

// value += 1;
// Console.WriteLine("Second increment: " + value);

// value++;
// Console.WriteLine("Third increment: " + value);

// value = value - 1;
// Console.WriteLine("First decrement: " + value);

// value -= 1;
// Console.WriteLine("Second decrement: " + value);

// value--;
// Console.WriteLine("Third decrement: " + value);

int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

// Converting Fahrenheit into Celcius
int fahrenheit = 94;
decimal celcius = (fahrenheit - 32m) * (5m / 9m);

Console.WriteLine("The temperature is " + celcius + " Celcius.");