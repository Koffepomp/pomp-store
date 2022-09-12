// Create list with stock
string[] stock =
{
    "Red Bull",
    "Bulle",
    "Fisksås",
    "Saftsoppa",
    "Ostmacka"
};
// Create list with winkelwagen content
string[] winkelwagen =
{

};

// Create list with user inventory
string[] userInventory =
{

};

// Create bool that keeps the store open
bool running = true;

while (running)
{
    // Clear screen and welcome user to the store
    WelcomeMessage();

    // Show available products
    ShowStock();
    Console.Write("\nWhat do you want to buy? ");

    string userInput = Console.ReadLine();

}
// Show what is in the winkelwagen

// Ask the user what they want to buy or bail from the store
// IF the product the user want is in stock
// Put the product in the shopping cart
// Remove product from stock
// ELSE
// Tell the user that the product is not available

void WelcomeMessage()
{
    Console.Clear();
    Console.WriteLine(" -----------------------------");
    Console.WriteLine("|| WELCOME TO THE POMP STORE ||");
    Console.WriteLine(" -----------------------------\n\n");
}

void ShowStock()
{
    foreach (string product in stock)
    {
        Console.WriteLine("- " + product);
    }
}
