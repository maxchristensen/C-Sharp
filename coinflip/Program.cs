Random random = new Random();
int coin = random.Next(0, 2);
if (coin == 0)
    Console.WriteLine("Heads!");
else
    Console.WriteLine("Tails!");

// Random coin = new Random();
// int flip = coin.Next(0, 2);
// Console.WriteLine((flip == 0) ? "heads" : "tails");