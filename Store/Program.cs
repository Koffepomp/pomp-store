// Welcome user to the app
Console.WriteLine(" -----------------------------");
Console.WriteLine("|| WELCOME TO THE POMP STORE ||");
Console.WriteLine(" -----------------------------");
// Show available products
// Show what is in the winkelwagen
// Ask the user what they want to buy or bail from the store
// IF the product the user want is in stock
// Put the product in the shopping cart
// Remove product from stock
// ELSE
// Tell the user that the product is not available

string[] warehouse =
{
    "old cheese",
    "stanky fish"
};
string[] shoppingCart =
{

};
string[] userInventory = {

};

Print("Welcome to my Gross Store!");
Print("Here's whats in the store: ");

PrintWarehouse();

string userInput = Console.ReadLine();

if (IsProductAvailable(userInput))
{
    PutProductInShoppingCart(userInput);
}
else
{
    Print("The product you are looking for doesn't exist...");
}


// METHODS

void PutProductInShoppingCart(string product)
{

}

bool IsProductAvailable(string product)
{
    foreach (string thing in warehouse)
    {
        if (thing == product)
            return true;
    }
    return false;
}

void PrintWarehouse()
{
    foreach (string ware in warehouse)
    {
        Console.WriteLine(" - " + ware);
    }
}

void Print(string msg)
{
    Console.WriteLine(msg);
}