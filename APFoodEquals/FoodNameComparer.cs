using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APFoodEquals
{
    class FoodNameComparer : Comparer<Food>
    {
        //singleton
        private static FoodNameComparer _instance = new FoodNameComparer();
        //readonly property to return instance
        public static FoodNameComparer Instance { get { return _instance; } }
        //ctor preventing instantiation
        private FoodNameComparer() { }

        public override int Compare(Food x, Food y)
        {
            if (x == null && y == null)
                return 0;
            if (x == null)
                return -1;
            if (y == null)
                return 1;
            int nameOrder = string.Compare(x.Name, y.Name,
                StringComparison.CurrentCulture);
            if (nameOrder != 0)
                return nameOrder;

            return string.Compare(
                x.Group.ToString(), y.Group.ToString(), StringComparison.CurrentCulture);

        }
    }
}
