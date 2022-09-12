// Create list with stock
List<string> stock = new();
stock.Add("Red Bull");
stock.Add("Bulle");
stock.Add("Fisksås");
stock.Add("Saftsoppa");
stock.Add("Ostmacka");
stock.Add("Gryta");

// Create list with winkelwagen content
List<string> winkelwagen = new();

// Create bool that keeps the store open
bool running = true;

while (running)
{
    // Clear screen and welcome user to the store
    WelcomeMessage();

    // Show available products
    ShowStock();

    // Show what is in the winkelwagen
    ShowWinkelwagen();

    // Ask user if he wants to buy something or leave the store
    Console.Write("\n\nWrite what you want or 'exit' to leave the store.");
    Console.Write("\nWhat do you want to do? ");
    string userInput = Console.ReadLine();

    // If user writes exit they leave the store
    if (userInput == "exit")
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nThanks for shopping at the Pomp Store! Please come again! <3");
        running = false;
    }
    else
        // IF the product the user want is in stock
        if (CheckIfProductIsInStock(userInput))
        {
        // Put the product in the shopping cart    
        AddToWinkelwagen(userInput);
        }
        else
        {
        // Tell the user that the product is not available
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nThis product is not available.");
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadLine();
    }
        // Remove product from stock    
}

void WelcomeMessage()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(" -----------------------------");
    Console.WriteLine("|| WELCOME TO THE POMP STORE ||");
    Console.WriteLine(" -----------------------------\n");
    Console.ForegroundColor = ConsoleColor.White;
}

void ShowStock()
{
    Console.WriteLine("ITEMS AVAILABLE:");
    foreach (string product in stock)
    {
        Console.WriteLine("- " + product);
    }
}

void ShowWinkelwagen()
{
    Console.Write("\nIn your winkelwagen: ");
    foreach (string product in winkelwagen)
    {
        Console.Write(product + ", ");
    }
}

bool CheckIfProductIsInStock(string product)
{
    foreach (string item in stock)
    {
        if (item == product)
            return true;
    }
    return false;
}

void AddToWinkelwagen(string product)
{
    winkelwagen.Add(product);
    stock.Remove(product);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("\n" + product + " added to your winkelwagen!");
    Console.ForegroundColor = ConsoleColor.White;
    Console.ReadLine();
}