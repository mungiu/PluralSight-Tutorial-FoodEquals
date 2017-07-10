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
            //instantiated 2 food items using different blueprints but able to assign
            //both to FoodGroup, since CookedFood inherits from Food
            Food apple = new Food("apple", FoodGroup.Fruit);
            Food apple2 = new Food("apple", FoodGroup.Fruit);
            CookedFood stewedApple = new CookedFood("stewed", "apple", FoodGroup.Fruit);
            CookedFood bakedApple = new CookedFood("baked", "apple", FoodGroup.Fruit);
            CookedFood stewedApple2 = new CookedFood("stewed", "apple", FoodGroup.Fruit);

            DisplayWhetherEqual(apple, stewedApple);
            DisplayWhetherEqual(stewedApple, bakedApple);
            DisplayWhetherEqual(stewedApple, stewedApple2);
            DisplayWhetherEqual(apple, apple2);
            DisplayWhetherEqual(apple, apple);
        }

        static void DisplayWhetherEqual(Food food1, Food food2)
        {
            if (food1 == food2)
                Console.WriteLine(string.Format("{0,12} == {1}", food1, food2));
            else
                Console.WriteLine(string.Format("{0,12} != {1}", food1, food2));
        }
    }
}
