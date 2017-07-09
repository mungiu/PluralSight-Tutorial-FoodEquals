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
            //instantiated 3 food items
            FoodItem banana = new FoodItem("banana", FoodGroup.Fruit);
            FoodItem banana2 = new FoodItem("banana", FoodGroup.Fruit);
            FoodItem chocolate = new FoodItem("chocolate", FoodGroup.Sweets);

            //comparing each food item in turn
            //we expect banana to equal to banana2 because they have same description
            //and same food group (recall overriding equalities in "FoodItem.cs"
            Console.WriteLine("banana == banana2: " + (banana == banana2));
            Console.WriteLine("banana2 == chocolate: " + (banana2 == chocolate));
            Console.WriteLine("chocolate == banana: " + (chocolate == banana));
        }
    }
}
