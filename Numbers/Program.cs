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

int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

// This will give us a combined score of what the students scored on all 5 projects
// Console.WriteLine("Sophia: " + sophiaSum);
// Console.WriteLine("Nicolas: " + nicolasSum);
// Console.WriteLine("Zahirah: " + zahirahSum);
// Console.WriteLine("Jeong: " + jeongSum);

// However, if we wanted the average we are going to need to do some additional computations

// Lets take that total sum that we got from the integers, and divide it by the number of assignments we said there would be- in this case, 5
// decimal sophiaScore = sophiaSum / currentAssignments;
// decimal nicolasScore = nicolasSum / currentAssignments;
// decimal zahirahScore = zahirahSum / currentAssignments;
// decimal jeongScore = jeongSum / currentAssignments;

// Notice how the WriteLine still computates the score as a integer. In order to get a decimal, we need to apply a technique called 'casting' to the integer in the equation.
// This is done by adding a (decimal)
decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
decimal jeongScore = (decimal) jeongSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");