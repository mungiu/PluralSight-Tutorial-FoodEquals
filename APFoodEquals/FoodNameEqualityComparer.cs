using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APFoodEquals
{
    class FoodNameEqualityComparer : EqualityComparer<FoodItem>
    {
        //singleton
        private static readonly FoodNameEqualityComparer _instance
            = new FoodNameEqualityComparer();
        //read only property
        public static FoodNameEqualityComparer Instance { get { return _instance; } }
        //ctor preventing multiple instantiation
        public FoodNameEqualityComparer() { }

        public override bool Equals(FoodItem x, FoodItem y)
        {
            return x.Name == y.Name && x.Group == y.Group;
        }

        public override int GetHashCode(FoodItem obj)
        {
            return obj.Name.GetHashCode() ^ obj.Group.GetHashCode();
        }
    }
}
