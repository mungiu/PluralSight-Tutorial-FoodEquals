using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APFoodEquals
{
    //sealed class, means nothing else will ever derive from it
    //affects how we implement equality
    public sealed class CookedFood : Food
    {
        public static bool operator ==(CookedFood x, CookedFood y)
        {
            //calling IEquatable<T> .Equals() (static method) and passing the 2 params
            //because we want the "==" operator do exactly what .Equals method does
            //static object.Equals() Deoes null-checking then calls virtual Equals()
            return object.Equals(x, y);
        }

        //same as above
        public static bool operator !=(CookedFood x, CookedFood y)
        {
            //returning opposite of whatever comes after "!"
            return !object.Equals(x, y);
        }

        public override bool Equals(object obj)
        {
            //using the Equals() method inherited from "Food" base class
            //therefore it is not necessary to override it again
            //AKA: Return true IF:
            //base.Equals() returns true
            //and derived type fields are equal
            if (!base.Equals(obj))
                return false;
            CookedFood rhs = (CookedFood)obj;
            return this._cookingMethod == rhs._cookingMethod;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this._cookingMethod.GetHashCode();
        }

        //tells you how the food is cooked
        private string _cookingMethod;

        public string CookingMethod { get { return _cookingMethod; } }

        //constructor with additional parameter
        public CookedFood(string cookingMethod, string name, FoodGroup group)
            : base(name, group)
        {
            this._cookingMethod = cookingMethod;
        }

        //concatinated the cooking method and the name
        public override string ToString()
        {
            {
                return string.Format("{0} {1}", _cookingMethod, Name);
            }
        }
    }
}
