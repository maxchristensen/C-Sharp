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

// We can use to the Contains function to search a string and return a boolean value to determine whether or not it has a specific word

string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

string intro = "Hello, My Name is Max.";
Console.WriteLine(intro.Contains("Hello"));

// Length counts the characters in a string and outputs the total
Console.WriteLine(intro.Length);

// StartsWith checks the string to see if whether or not it starts with a specific input- returns a boolean value
Console.WriteLine(intro.StartsWith("Hel"));
Console.WriteLine(intro.StartsWith("Hi"));

// EndsWith checks the string to see if whether or not it end with a specific input- returns a boolean value
Console.WriteLine(intro.EndsWith("ax."));
Console.WriteLine(intro.EndsWith(".  "));