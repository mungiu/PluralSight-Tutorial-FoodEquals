using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APFoodEquals
{
    //inheriting from IEquatable
    //creating a generalized method measure equality of different instances
    public struct FoodItem : IEquatable<FoodItem>
    {
        private readonly string _name;
        private readonly FoodGroup _group;

        public string Name { get { return _name; } }
        public FoodGroup Group { get { return _group; } }

        //constructor that sets incoming values to necessary fields
        public FoodItem(string name, FoodGroup group)
        {
            this._name = name;
            this._group = group;
        }

        //converts an object to its string representation
        //but we override it
        public override string ToString()
        {
            return _name;
        }

        //== operator overload
        public static bool operator ==(FoodItem lhs, FoodItem rhs)
        {
            //calling IEquatable<T> .Equals()
            return lhs.Equals(rhs);
        }

        //same as equality operator
        public static bool operator !=(FoodItem lhs, FoodItem rhs)
        {
            return !lhs.Equals(rhs);
        }

        //overriding GetHashCode because it works closely with equality
        // ^ = the exclusive OR operator (we are Exclusive Orring the "GetHashCode()"
        //invloves XOR the hash code of all the fields used to evaluate equality
        public override int GetHashCode()
        {
            return _name.GetHashCode() ^ _group.GetHashCode();
        }

        //using IEquatable<T>, a strongly typed equals method
        public bool Equals(FoodItem other)
        {
            return this._name == other._name && this._group == other._group;
        }

        //overloading equality operator, type checking
        public override bool Equals(object obj)
        {
            //calling IEquatable<T> .Equals()
            //because of the boxing this method is still much slower than IEquatable
            if (obj is FoodItem)
                return Equals((FoodItem)obj);
            else
                return false;
        }
    }
}    
