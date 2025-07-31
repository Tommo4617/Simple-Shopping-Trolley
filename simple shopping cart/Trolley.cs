using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_shopping_cart
{
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
}
