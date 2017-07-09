using System;

namespace APFoodEquals
{
    public enum FoodGroup { Meat, Fruit, Vegetables, Sweets }

    //inheriting from IEquatable
    //creating a generalized method measure equality of different instances
    public struct FoodItem : IEquatable<FoodItem>
    {
        private readonly string _name;
        private readonly FoodGroup _group;

        public string Name { get { return _name; } }
        public FoodGroup Group { get { return _group; } }

        //constructor that sets necessary fields
        public FoodItem(string Name, FoodGroup Group)
        {
            this._name = Name;
            this._group = Group;
        }

        //converts an object to its string representation
        //but we override it
        public override string ToString()
        {
            return _name;
        }

        //overloading equality operator
        //comparing left hand side fooditem to right hand side food item
        //notice there is no type check, input parameters have to match exactly
        public static bool operator ==(FoodItem lhs, FoodItem rhs)
        {
            return lhs.Equals(rhs);
        }

        //ovrloading the inequality operator (required is equality has the same)
        public static bool operator !=(FoodItem lhs, FoodItem rhs)
        {
            return !lhs.Equals(rhs);
        }

        //overriding GetHashCode because it works closely with equality
        //therefore if equality is overriden than so should GetHasCode();
        // ^ = the exclusive OR operator
        public override int GetHashCode()
        {
            return _name.GetHashCode() ^ _group.GetHashCode();
        }

        //comparing different instances by using IEquatable properties
        public bool Equals(FoodItem other)
        {
            return this._name == other._name && this._group == other._group;
        }

        //attempting to perform the same as "public bool Equals" from above
        public override bool Equals(object obj)
        {
            //checking that object passed as a parameter is a food item
            //because of the boxing this method is still much slower than IEquatable
            if (obj is FoodItem)
                return Equals((FoodItem)obj);
            else
                return false;
        }
    }
}    
