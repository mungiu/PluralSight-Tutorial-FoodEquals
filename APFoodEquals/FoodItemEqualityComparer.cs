using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APFoodEquals
{
    class FoodItemEqualityComparer : EqualityComparer<FoodItem>
    {
        //singleton
        private static readonly FoodItemEqualityComparer _instance =
            new FoodItemEqualityComparer();
        //read only property
        public static FoodItemEqualityComparer Instance { get { return _instance; } }
        //ctor preventing initialization
        private FoodItemEqualityComparer() { }


        //base class abstract method override
        public override bool Equals(FoodItem x, FoodItem y)
        {
            ////testing equality by first converting to upper case
            ////to exclude case sensitivity
            //return x.Name.ToUpperInvariant() == y.Name.ToUpperInvariant()
            //    && x.Group == y.Group;

            return StringComparer.OrdinalIgnoreCase.Equals(x.Name, y.Name)
                && x.Group == y.Group;
        }

        // -||-||-||-
        public override int GetHashCode(FoodItem obj)
        {
            //// -||-||-||-
            //return obj.Name.ToUpperInvariant().GetHashCode() ^
            //    obj.Group.GetHashCode();

            return StringComparer.OrdinalIgnoreCase.GetHashCode(obj.Name)
                ^ obj.Group.GetHashCode();
        }
    }
}
