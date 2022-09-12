// Create list with stock
using System.Xml;

List<string> stock = new();
stock.Add("Red Bull");
stock.Add("Bread");
stock.Add("Pompsauce");
stock.Add("Peacebloom");
stock.Add("Cheese");
stock.Add("Boiler");

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
        Message("\nThanks for shopping at the Pomp Store! Please come again! <3", "Cyan");
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
        Message("'" + userInput + "' is not available in the store. Get your shit together.", "Red");
        Console.ReadLine();
    }
        // Remove product from stock    
}

// Clear screen and show welcome message
void WelcomeMessage()
{
    Console.Clear();
    Message(" -----------------------------\n|| WELCOME TO THE POMP STORE ||\n -----------------------------\n", "Yellow");
}

// Shows available items in stock
void ShowStock()
{
    Console.WriteLine("ITEMS AVAILABLE:");
    foreach (string product in stock)
    {
        Console.WriteLine("- " + product);
    }
}

// Shows items that have been bought
void ShowWinkelwagen()
{
    Console.Write("\nIn your winkelwagen: ");
    foreach (string product in winkelwagen)
    {
        Console.Write(product + ", ");
    }
}

// Check stock before buying a product
bool CheckIfProductIsInStock(string product)
{
    foreach (string item in stock)
    {
        if (item == product)
            return true;
    }
    return false;
}

// Adds a product to the winkelwagen
void AddToWinkelwagen(string product)
{
    winkelwagen.Add(product);
    stock.Remove(product);
    Message((product + " added to your winkelwagen!"), "Green");
    Console.ReadLine();
}

void Message(string msg, string color)
{
    if (color == "Green")
        Console.ForegroundColor = ConsoleColor.Green;
    else if (color == "Red")
        Console.ForegroundColor = ConsoleColor.Red;
    else if (color == "Yellow")
        Console.ForegroundColor = ConsoleColor.Yellow;
    else if (color == "Cyan")
        Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\n" + msg);
    Console.ForegroundColor = ConsoleColor.White;
}