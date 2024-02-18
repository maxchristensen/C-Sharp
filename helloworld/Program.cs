// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Max!");

// Strings are a sequence of characters strung together
string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

// Trim is a method used to remove leading and trailing spaces
string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");

// TrimStart removes leading spaces
string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

// TrimEnd removes trailing spaces
trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

// Trim removes both leading and trailing spaces
trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());