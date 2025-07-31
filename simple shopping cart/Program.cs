// See https://aka.ms/new-console-template for more information
using simple_shopping_cart;
bool exit = false;
Trolley trolley = new Trolley();

while (!exit)
{
    Console.WriteLine("What food do you want to add? (leave empty to see reciept)");
    string foodName = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(foodName))
    {
        trolley.DisplayReciept();
        exit = true;
        break;
    }
    Console.WriteLine("What is the price of the food?");
    double foodPrice;
    while (!double.TryParse(Console.ReadLine(), out foodPrice) || foodPrice < 0)
    {
        Console.WriteLine("Please enter a valid price (e.g. 17.99, 12, 3.50)");
    }
    Food food = new Food { name = foodName, price = foodPrice };
    trolley.AddFood(food);
}
Environment.Exit(0);

