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
            Food[] list =
            {
                new Food("apple", FoodGroup.Fruit),
                new Food("pear", FoodGroup.Fruit),
                new CookedFood("baked", "apple", FoodGroup.Fruit)
            };
            SortAndShowList(list);
            Console.WriteLine();

            Food[] list2 =
            {
                new CookedFood("baked", "apple", FoodGroup.Fruit),
                new Food("apple", FoodGroup.Fruit),
                new Food("pear", FoodGroup.Fruit)
            };
            SortAndShowList(list2);
        }

        static void SortAndShowList(Food[] list)
        {
            Array.Sort(list, FoodNameComparer.Instance);

            foreach (var item in list)
                Console.WriteLine(item);
        }
            
    }
}
