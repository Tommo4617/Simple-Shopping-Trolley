# Simple-Shopping-Trolley

## Objective
To pracice some simple OOP concepts to gain confidence in writing code unaided. Create a simple program with a trolley class and a food class. Each food item should have a name and a price. The trolley should store a list of food items and should allow the user to add items to the trolley and see their reciept (a list of all items and their prices, alongside a total cost.

## Key ideas to consider
This is just simple OOP practicec, the aim isnt to go overboard with OOP fundamentals, just writing a simple program with classes and objects without external help.

## Code snippets

### Trolley class

```
    internal class Trolley
    {
        public List<Food> currentFoodShop = new List<Food>();

        public void AddFood(Food food)
        {
            currentFoodShop.Add(food);
        }

        public void RemoveFood(Food food)
        {
            currentFoodShop.Remove(food);
        }

        public double CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (var food in currentFoodShop)
            {
                totalPrice += food.price;
            }
            return totalPrice;
        }

        public void DisplayReciept()
        {
            Console.WriteLine("Items in the trolley:");
            foreach (var food in currentFoodShop)
            {
                Console.WriteLine($"- {food.name}: £{food.price}");
            }
            Console.WriteLine($"Total Price: £{CalculateTotalPrice()}");
        }
    }
```

### Food class

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_shopping_cart
{
    internal class Food
    {
        public string name { get; set; }
        public double price { get; set; }
    }
}
```

## Next steps

Write a program the focuses on: polymorphism, encapsulation, abstraction and inheritance.
