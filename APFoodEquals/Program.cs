using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APFoodEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            //hashset allows similar items to be added to the list only once
            //item similarity can be evaluate by default of using customer comparers
            var foodItems = new HashSet<FoodItem>(EqualityComparer<FoodItem>.Default)
            {
                new FoodItem("apple", FoodGroup.Fruit),
                new FoodItem("pear", FoodGroup.Fruit),
                new FoodItem("pineapple", FoodGroup.Fruit),
                new FoodItem("Apple", FoodGroup.Fruit)
            };
            foreach (var foodItem in foodItems)
                Console.WriteLine(foodItem);
        }

    }
}
